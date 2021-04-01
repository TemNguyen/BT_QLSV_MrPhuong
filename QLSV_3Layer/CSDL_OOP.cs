using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer
{
    class CSDL_OOP
    {
        public List<Student> ListStudent { get; set; }
        public List<Class> ListClass { get; set; }
        public static CSDL_OOP Instance 
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        private static CSDL_OOP _Instance;
    }
}
