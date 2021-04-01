using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_3Layer
{
    class CSDL_OOP
    {
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
        public List<Student> ListStudent = new List<Student>();
        public List<Class> ListClass = new List<Class>();

        public List<Student> getAllStudent()
        {
            foreach(DataRow dr in CSDL.Instance.DTSV.Rows)
            {

                    ListStudent.Add(getStudent(dr));
                
            }
            return ListStudent;
        }
        public List<Class> getAllClass()
        {
            foreach(DataRow dr in CSDL.Instance.DTLSH.Rows)
            {
                ListClass.Add(getClass(dr));
            }
            return ListClass;
        }
        public Student getStudent(DataRow dr)
        {
            Student s = new Student();
            s.StudentID = dr["StudentID"].ToString();
            s.Name = dr["Name"].ToString();
            s.Gender = Convert.ToBoolean(dr["Gender"]);
            s.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
            s.ClassID = Convert.ToInt32(dr["ClassID"]);
            return s;
        }
        public Class getClass(DataRow dr)
        {
            Class c = new Class();
            c.ClassID = Convert.ToInt32(dr["ClassID"]);
            c.ClassName = dr["ClassName"].ToString();
            return c;
        }
        
    }
}
