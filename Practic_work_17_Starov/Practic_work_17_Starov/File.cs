using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_work_17_Starov
{
    public enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
    internal struct File
    {
        public FileAccess Permissions { get; set; }

        public bool CanRead()
        {
            return Permissions.HasFlag(FileAccess.Read);
        }

        public bool CanWrite()
        {
            return Permissions.HasFlag(FileAccess.Write);
        }

        public bool CanExecute()
        {
            return Permissions.HasFlag(FileAccess.Execute);
        }
    }
}
