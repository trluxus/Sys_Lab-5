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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm.Notes.Count!=0)
            {
                var byStud = from data in MainForm.Notes orderby data.stdt.Name select data;
                MainForm.binding.DataSource = byStud;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MainForm.Notes.Count != 0)
            {
                var bySub = from data in MainForm.Notes orderby data.sub.Name select data;
                MainForm.binding.DataSource = bySub;
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm.binding.DataSource = MainForm.Notes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MainForm.Notes.Count != 0)
            {
                var FilBySub = from data in MainForm.Notes where data.sub.Name == textBox1.Text.ToString() select data;
                MainForm.binding.DataSource = FilBySub;
            }   
        }
    }
}
