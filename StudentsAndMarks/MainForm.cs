using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsAndMarks
{
    public partial class MainForm : Form
    {
        public struct Note
        {
            Student stdt;
            Subject sub;
            int mark;
        }


        public static List<Student> Studs = new List<Student>();
       // public static List<Subject> Sub = new List<Subject>();
        //public static List<Note> Notes = new List<Note>();
        public MainForm()
        {
            
           // BindingSource binding = new BindingSource();

           // binding.DataSource = Notes;
            //DG_Main.DataSource = Notes;
            InitializeComponent();
        }

        private void studentsEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsEditor StudEd = new StudentsEditor();

            StudEd.Show();
        }
    }
}
