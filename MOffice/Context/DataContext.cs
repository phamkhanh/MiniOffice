using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOffice.Context
{
    public class DataContext
    {
        private static MOfficeEntities _Entities;

        public MOfficeEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        private static DataContext instance; // Ctrl + R + E

        public static DataContext Instance
        {
            get { if (instance == null) instance = new DataContext(); return DataContext.instance; }
            private set { DataContext.instance = value; }
        }

        private DataContext()
        {
            Entities = new MOfficeEntities();
            Entities.Configuration.ProxyCreationEnabled = false;
            Entities.Configuration.LazyLoadingEnabled = false;
        }
    }
}
