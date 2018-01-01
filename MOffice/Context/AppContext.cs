using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOffice.Context
{
    public sealed class AppContext
    {
        private static readonly MOfficeEntities instance = new MOfficeEntities();

        static AppContext() { }

        private AppContext() { }

        public static MOfficeEntities Instance
        {
            get { return instance; }
        }
    }
}
