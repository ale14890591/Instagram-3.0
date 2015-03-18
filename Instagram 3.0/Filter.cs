using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Instagram_3._0
{
    internal abstract class Filter
    {
        protected bool _cancelled = false;

        internal event Action<int> ProgressChanged;
        internal event Action<bool> Completed;

        public virtual void Cancel(object sender, EventArgs e)
        {
            _cancelled = true;
        }

        public virtual void ProcessImage()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (_cancelled)
                    break;

                Thread.Sleep(50);
                OnProgressChanged(i);
            }

            OnCompleted(_cancelled);
        }

        private void OnProgressChanged(int i)
        {
            if (ProgressChanged != null)
                ProgressChanged(i);
        }

        private void OnCompleted(bool b)
        {
            if (Completed != null)
                Completed(b);
        }
    }
}
