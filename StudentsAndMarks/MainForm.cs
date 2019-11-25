using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace StudentsAndMarks
{
    public partial class MainForm : Form
    {
        public static BindingSource binding = new BindingSource();
        public static List<Student> Studs = new List<Student>();
        public static List<Subject> Subjects = new List<Subject>();
        public static List<Note> Notes = new List<Note>();

        public MainForm()
        {
            InitializeComponent();
            binding.DataSource = Notes;
            DG_Main.DataSource = binding;
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JournalForm Journal = new JournalForm();

            if(Journal.ShowDialog(this)==DialogResult.Cancel)
            {
                Journal.Dispose();
                
            }
            binding.ResetBindings(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm rf = new RequestForm();
       
            rf.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XmlSerializer formatStudent = new XmlSerializer(typeof(List<Student>));
            XmlSerializer formatSubject = new XmlSerializer(typeof(List<Subject>));
            XmlSerializer formatNote     = new XmlSerializer(typeof(List<Note>));

            using (FileStream file = new FileStream("Studs.xml", FileMode.Create))
            {
                formatStudent.Serialize(file, Studs);
            }

            using (FileStream file = new FileStream("Subjects.xml", FileMode.Create))
            {
                formatSubject.Serialize(file, Subjects);
            }

            using (FileStream file = new FileStream("Notes.xml", FileMode.Create))
            {
                formatNote.Serialize(file, Notes);
            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer formatStudent = new XmlSerializer(typeof(List<Student>));
            XmlSerializer formatSubject = new XmlSerializer(typeof(List<Subject>));
            XmlSerializer formatNote = new XmlSerializer(typeof(List<Note>));

            try {
                using (FileStream file = new FileStream("Studs.xml", FileMode.Open))
                {
                    Studs = formatStudent.Deserialize(file) as List<Student>;
                }

                using (FileStream file = new FileStream("Subjects.xml", FileMode.Open))
                {
                    Subjects = formatSubject.Deserialize(file) as List<Subject>;
                }

                using (FileStream file = new FileStream("Notes.xml", FileMode.Open))
                {
                    Notes = formatNote.Deserialize(file) as List<Note>;
                }
                binding.DataSource = Notes;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Can't find saves", "Warning");
            }
            
        }
    }
}
