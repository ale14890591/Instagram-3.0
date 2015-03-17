using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Instagram_3._0.Filters
{
    internal class GrayFilter : IFilter
    {
        public static readonly string _name = "Gray Filter";
        private bool _cancelled = false;

        internal event Action<int> ProgressChanged;
        internal event Action<bool> Completed;

        public void Cancel()
        {
            _cancelled = true;
        }

        public void ProcessImage()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (_cancelled)
                    break;

                Thread.Sleep(50);
                ProgressChanged(i);
            }

            Completed(_cancelled);
        }
    }
}
