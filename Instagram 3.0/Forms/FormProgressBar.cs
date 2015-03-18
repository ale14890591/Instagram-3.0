using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram_3._0
{
    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            InitializeComponent();
        }

        public void SetProgressBar(int value)
        {
            try
            {
                Invoke(
                    new Action(
                        () =>
                        {
                            progressBar.Value = value < 100 ? value + 1 : value;//для мгновенного останова прогресс бара при отмене
                            progressBar.Value = value;
                        }
                ));
            }
            catch (ObjectDisposedException)
            {
            }
        }

        public void SetButtonCancelClickEvent(EventHandler action)
        {
            buttonCancel.Click += action;
        }

        public void SetDisposedEvent(FormClosingEventHandler action)
        {
            this.FormClosing += action;
        }
    }
}
