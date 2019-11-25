using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAndMarks
{
    [Serializable]
    public class Student
    {
        private static int count = 0;
        private string _Name;
        public int id { get; set; }

        public string Name
        {
            get { return _Name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Name can't be empty or contain white spaces", "Warning");
                    throw new Exception("IanappropriateName");
                }

                _Name = value;
            }
        }

        public Student() 
        {
            id = count;
            count+=1;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
