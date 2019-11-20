using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAndMarks
{
    public class Subject
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Name can't be empty or contain white spaces", "Warning");
                    return;
                }

                _Name = value;
            }
        }
    }
}
