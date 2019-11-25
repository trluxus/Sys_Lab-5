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
    public partial class JournalForm : Form
    {
        private BindingSource bindingStud = new BindingSource();
        private BindingSource bindingSub = new BindingSource();
        //private BindingSource bindingMark = new BindingSource();
        public static int StudIndex = 0;
        public static int SubIndex = 0;
        public static int Field = 0;
        public JournalForm()
        {
            InitializeComponent();
            bindingStud.DataSource = MainForm.Studs;
            bindingSub.DataSource = MainForm.Subjects;
            
            LB_Students.DataSource = bindingStud;
            LB_Subjects.DataSource = bindingSub;           
        }

        private void LB_Students_DoubleClick(object sender, EventArgs e)
        {

            if (LB_Students.SelectedIndex != -1)
            {
                StudIndex = LB_Students.SelectedIndex;
                Field = 0;
                EditItem Edit = new EditItem();


                switch (Edit.ShowDialog(this))
                {
                    case DialogResult.OK:
                        if (MainForm.Studs[LB_Students.SelectedIndex].Name != Edit.tbProposeName.Text.ToString())
                        {
                            try { MainForm.Studs[LB_Students.SelectedIndex].Name = Edit.tbProposeName.Text.ToString(); }
                            catch (Exception) { }
                        }


                        bindingStud.ResetBindings(false);
                        break;

                    case DialogResult.Yes:
                        for (int i = 0; i < MainForm.Notes.Count(); i++)
                        {
                            if (MainForm.Notes[i].stdt.id == MainForm.Studs[LB_Students.SelectedIndex].id)
                            {
                                MainForm.Notes.RemoveAt(i);
                                i--;
                            }
                        }

                        MainForm.binding.ResetBindings(true);
                        MainForm.Studs.RemoveAt(LB_Students.SelectedIndex);
                        bindingStud.ResetBindings(false);
                        break;

                    case DialogResult.Cancel:
                        Edit.Dispose();
                        break;
                }


            }
        }

        private void B_AddStudent_Click(object sender, EventArgs e)
        {
            try 
            { 
                Student Stud = new Student() { Name = TB_StudName.Text.ToString() };
                MainForm.Studs.Add(Stud);
            }
            catch (Exception) { }
            
            bindingStud.ResetBindings(true);

            TB_StudName.Text = null;
        }

        private void B_AddSubject_Click(object sender, EventArgs e)
        {
            try
            {
                Subject Sub = new Subject() { Name = TB_SubName.Text.ToString() };
                MainForm.Subjects.Add(Sub);
            }
            catch (Exception) { }

            bindingSub.ResetBindings(true);

            TB_SubName.Text = null;
        }

        private void LB_Subjects_DoubleClick(object sender, EventArgs e)
        {
            if (LB_Subjects.SelectedIndex != -1)
            {
                Field = 1;
                SubIndex = LB_Subjects.SelectedIndex;
                EditItem Edit = new EditItem();


                switch (Edit.ShowDialog(this))
                {
                    case DialogResult.OK:
                        if (MainForm.Subjects[LB_Subjects.SelectedIndex].Name != Edit.TB_Name.Text.ToString())
                        {
                            try
                            {
                                MainForm.Subjects[LB_Subjects.SelectedIndex].Name = Edit.TB_Name.Text.ToString();
                            }
                            catch (Exception) { };
                        }


                        bindingSub.ResetBindings(false);
                        break;

                    case DialogResult.Yes:
                        for (int i = 0; i < MainForm.Notes.Count(); i++)
                        {
                            if (MainForm.Notes[i].sub.id == MainForm.Subjects[LB_Subjects.SelectedIndex].id)
                            {
                                MainForm.Notes.RemoveAt(i);

                                i--;
                            }
                        }
                        MainForm.binding.ResetBindings(true);
                        MainForm.Subjects.RemoveAt(LB_Subjects.SelectedIndex);

                        bindingSub.ResetBindings(false);
                        break;

                    case DialogResult.Cancel:
                        Edit.Dispose();
                        break;
                }


            }
        }

        private void B_AddMark_Click(object sender, EventArgs e)
        {
            if (LB_Students.SelectedIndex != -1 && LB_Subjects.SelectedIndex != -1)
            {
                Note note = new Note() { stdt = MainForm.Studs[LB_Students.SelectedIndex], sub = MainForm.Subjects[LB_Subjects.SelectedIndex], mark = 0 };

                int tmp;
                if (Int32.TryParse(TB_Mark.Text, out tmp))
                    note.mark = tmp;
                else
                {
                    MessageBox.Show("You must input value for Mark", "Warning");
                    return;
                }

                if (tmp < 0)
                {
                    MessageBox.Show("You must input value more then zero for Mark", "Warning");
                    return;
                }

                if (MainForm.Notes.Exists(x => x.stdt.id == note.stdt.id && x.sub.id == note.sub.id))
                {
                    for (int i = 0; i < MainForm.Notes.Count(); i++)
                    {
                        if (MainForm.Notes[i].stdt.id == note.stdt.id && MainForm.Notes[i].sub.id == note.sub.id)
                        {
                            MainForm.Notes[i].mark = Convert.ToInt32(TB_Mark.Text);
                            //bindingMark.ResetBindings(true);
                            MainForm.binding.ResetBindings(true);
                            TB_Mark.Text = null;
                            return;
                        }
                    }
                }
                
               
                note.stdt = MainForm.Studs[LB_Students.SelectedIndex];
                note.sub = MainForm.Subjects[LB_Subjects.SelectedIndex];

                MainForm.Notes.Add(note);
                //bindingMark.ResetBindings(true);
                MainForm.binding.ResetBindings(true);
                TB_Mark.Text = null;

            }
            else
                MessageBox.Show("You must choose Student and Subject to put Mark", "Warning");
        }

        private void LB_Students_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Students.SelectedItem != null && LB_Subjects.SelectedItem != null)
                for (int i = 0; i < MainForm.Notes.Count(); i++)
                {
                    if (MainForm.Notes[i].stdt == LB_Students.SelectedItem && MainForm.Notes[i].sub == LB_Subjects.SelectedItem)
                    {
                        //bindingMark.DataSource = MainForm.Notes[i];
                        //bindingMark.ResetBindings(true);
                        return;
                    }
                }
        }

        private void LB_Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_Students.SelectedIndex != -1 && LB_Subjects.SelectedIndex != -1)
                for (int i = 0; i < MainForm.Notes.Count(); i++)
                {
                    if (MainForm.Notes[i].stdt == LB_Students.SelectedItem && MainForm.Notes[i].sub == LB_Subjects.SelectedItem)
                    {
                        //bindingMark.DataSource = MainForm.Notes[i];
                        //bindingMark.ResetBindings(true);
                        return;
                    }
                }
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            MainForm.binding.DataSource = MainForm.Notes;
            if (LB_Students.SelectedIndex != -1 && LB_Subjects.SelectedIndex != -1)
            for (int i = 0; i < MainForm.Notes.Count(); i++)
            {
                if (MainForm.Notes[i].stdt == LB_Students.SelectedItem && MainForm.Notes[i].sub == LB_Subjects.SelectedItem)
                {
                    //bindingMark.DataSource = MainForm.Notes[i];
                    //bindingMark.ResetBindings(true);
                    return;
                }
            }

            //bindingMark.DataSource = MainForm.Notes;
            //TB_Mark.DataBindings.Add("Text", bindingMark, "mark");
        }
    }
}
/*
 if(LB_Students.SelectedIndex!=-1)
            {
                Note note = new Note() { stdt = MainForm.Studs[LB_Students.SelectedIndex], sub = MainForm.Subjects[LB_Subjects.SelectedIndex], mark = 0 };
                if (MainForm.Notes.Contains(note))
                {

                    for (int i = 0; i < MainForm.Notes.Count(); ++i)
                    {
                        if (MainForm.Notes[i].stdt.id == note.stdt.id && MainForm.Notes[i].sub.id == note.sub.id)
                        {
                            //bindingMark.DataSource = MainForm.Notes[i];
                            bindingMark.Position -= bindingMark.Position;
                            bindingMark.Position += i;
                            bindingMark.ResetBindings(true);
                        }
                    }

                }
            }
*/