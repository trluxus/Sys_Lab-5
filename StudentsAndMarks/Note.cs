using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndMarks
{
    [Serializable]
    public class Note
    {
        public Student stdt { get; set; }
        public Subject sub { get; set; }
        public int mark { get; set; }

        public bool Equals(Note other)
        {
            if (other == null) return false;
            return (this.stdt.id.Equals(other.stdt.id) && this.sub.id.Equals(other.sub.id));
        }
    }
}
