using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_3._0
{
    public partial class FormMain : Form
    {
        private Dictionary<string, Type> _filterDictionary;
        private FormProgressBar _formProgressBar;
        private bool _filterApplying = false;

        public FormMain()
        {
            InitializeComponent();
            var filters = GetFilters();
            InitializeListBoxFilters(filters);
            _filterDictionary = GetFilterDictionary(filters);
        }

        private void LoadPicture(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files(*.JPG;*.JPEG;*.PNG)|*.JPG;*.JPEG;*.PNG|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                Image i = Image.FromFile(openDialog.FileName);
                Bitmap b = new Bitmap(i, (int)(pictureBox.Width), (int)(i.Height * pictureBox.Width / i.Width));
                pictureBox.Image = b;
            }
        }

        private void ClearPictureBox(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private IEnumerable<Type> GetFilters()
        {
            return Assembly.GetCallingAssembly().GetTypes().Where(type => type.IsSubclassOf(typeof(Filter)));
        }

        private void InitializeListBoxFilters(IEnumerable<Type> filterTypes)
        {
            foreach (var filterType in filterTypes)
            {
                listBoxFilters.Items.Add(filterType.GetField("_name").GetValue(null));
            }
        }

        private Dictionary<string, Type> GetFilterDictionary(IEnumerable<Type> filterTypes)
        {
            Dictionary<string, Type> filterDictionary = new Dictionary<string, Type>();

            foreach (var filterType in filterTypes)
            {
                filterDictionary.Add(filterType.GetField("_name").GetValue(null).ToString(), filterType);
            }

            return filterDictionary;
        }

        private void ApplyFilter(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (!_filterApplying)
                {
                    _filterApplying = true;
                    Filter filter = (Filter)Activator.CreateInstance(_filterDictionary[(sender as ListBox).SelectedItem as string]);
                    ShowApplyingProcess(filter);
                    filter.Completed += ShowApplyingProcessEndMessage;

                    Task taskProcessingImage = Task.Factory.StartNew(filter.ProcessImage);
                }
                else
                {
                    MessageBox.Show("You cannot apply more than one filter at the same time");
                }
            }
            else
            {
                MessageBox.Show("No loaded image");
            }
        }

        private void ShowApplyingProcess(Filter filter)
        {
            _formProgressBar = new FormProgressBar();
            filter.ProgressChanged += _formProgressBar.SetProgressBar;
            _formProgressBar.SetButtonCancelClickEvent(new EventHandler(filter.Cancel));
            _formProgressBar.SetDisposedEvent(new FormClosingEventHandler(filter.Cancel));
            _formProgressBar.Show();
        }

        private void ShowApplyingProcessEndMessage(bool cancelled)
        {
            if (cancelled)
                MessageBox.Show("Applying has been cancelled", "Cancelled");
            else
                MessageBox.Show("Filter has been applied successfully", "Success");

            Invoke(
                new Action(
                    () =>
                        _formProgressBar.Close()
            ));

            _filterApplying = false;
        }
        
        private void DetermineHoveredItem(object sender, EventArgs e)
        {
            Point cursorPosition = Cursor.Position;
            int index = listBoxFilters.IndexFromPoint(listBoxFilters.PointToClient(cursorPosition));
            if (index != -1)
            {
                Type filterType = _filterDictionary[listBoxFilters.Items[index] as string];
                string filterDescription = filterType.GetField("_description").GetValue(null).ToString();
                ToolTip t = new ToolTip();
                t.Show(filterDescription, listBoxFilters, 2000);
            }
        }
    }
}
