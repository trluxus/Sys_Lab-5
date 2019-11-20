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
    public partial class StudentsEditor : Form
    {
        private BindingSource binding = new BindingSource();
        public StudentsEditor()
        {
            InitializeComponent();
            binding.DataSource = MainForm.Studs;
            LB_Students.DataSource = binding;

        }

        private void LB_Students_DoubleClick(object sender, EventArgs e)
        {
            if (LB_Students.SelectedIndex != -1)
            {
                EditStudent EdStud = new EditStudent();

                switch (EdStud.ShowDialog(this))
                {
                    case DialogResult.OK:
                        if (MainForm.Studs[LB_Students.SelectedIndex].Name != EdStud.TB_Name.Text.ToString())
                            MainForm.Studs[LB_Students.SelectedIndex].Name = EdStud.TB_Name.Text.ToString();

                        binding.ResetBindings(false);
                        break;

                    case DialogResult.Yes:
                        MainForm.Studs.RemoveAt(LB_Students.SelectedIndex);
                        binding.ResetBindings(false);
                        break;

                    case DialogResult.Cancel:
                        EdStud.Dispose();
                        break;
                }
           

            }
        }

        private void B_Add_Click(object sender, EventArgs e)
        {
            Student Stud = new Student() { Name = TB_Name.Text.ToString() };

            MainForm.Studs.Add(Stud);

            binding.ResetBindings(false);

            TB_Name.Text = "";
        }


        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
