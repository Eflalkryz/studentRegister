using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace studentRegister
{
    public partial class StudentRegistration : Form
    {

        studentEntities db = new studentEntities();

        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentPage_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            studentData();
            lessonData();
            notesData();
            FillLessonComboBox();
            allRowButtons();

        }

        private void allRowButtons()
        { 
            //Notes Update column

            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "";
            updateButtonColumn.Name = "UpdateButtonColumn";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;

            // Silme butonu sütununu DataGridView'e ekle
            NotesDataGridwiew.Columns.Add(updateButtonColumn);

            //Lesson Delete Column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.HeaderText = "";
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.Text = "Sil";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            // Silme butonu sütununu DataGridView'e ekle
            studentLessonGridview.Columns.Add(deleteButtonColumn);


            //Student Delete Column
            DataGridViewButtonColumn deleteButtonColumn2 = new DataGridViewButtonColumn();
            deleteButtonColumn2.HeaderText = "";
            deleteButtonColumn2.Name = "DeleteButtonColumn";
            deleteButtonColumn2.Text = "Sil";
            deleteButtonColumn2.UseColumnTextForButtonValue = true;

            // Silme butonu sütununu DataGridView'e ekle
            studentDataGridView.Columns.Add(deleteButtonColumn2);



        }

        #region DataGörüntüleme
        private void studentData()
        {
            var query = from x in db.Student
                        select new
                        {
                            x.Id,
                            x.FirstName,
                            x.LastName,
                            x.PhoneNumber,
                            x.Adress
                        };
            studentDataGridView.DataSource = query.ToList();

            

            
        }

        private void lessonData()
        {
            var query = from x in db.Lesson
                        select new
                        {
                            x.Id,
                            x.LessonName,
                            x.TotCredit
                        };
            studentLessonGridview.DataSource = query.ToList();

            

            
        }

        private void notesData()
        {
            var result = db.Note.Select(x => new
            {
                Id = x.Id,
                FirstName = x.Student.FirstName,
                LastName = x.Student.LastName,
                LessonName = x.Lesson.LessonName,
                Exam1 = x.Exam1,
                Exam2 = x.Exam2,
                Average = x.Average,
                State = x.State
            }) ;;
            NotesDataGridwiew.DataSource = result.ToList();

        }
        #endregion

        #region dataGridviews
        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentDataGridView.Columns["DeleteButtonColumn2"].Index && e.RowIndex >= 0)
            {
                // Silme işlemi
                if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(studentDataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                    deleteStudent(id);

                    studentDataGridView.DataSource = db.Student.ToList();


                }
            }


        }

        
        private void studentLessonGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == studentLessonGridview.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                // Silme işlemi
                if (MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(studentLessonGridview.Rows[e.RowIndex].Cells["Id"].Value);

                    deleteLesson(id);

                    var query = from x in db.Lesson
                                select new
                                {
                                    x.Id,
                                    x.LessonName,
                                    x.TotCredit
                                };
                    studentLessonGridview.DataSource = query.ToList();
                }
            }
        }
        #endregion


        #region deleteMethods
        private void deleteStudent(int id)
        {
            Student student = db.Student.Find(id);
            db.Student.Remove(student);
            db.SaveChanges();
            MessageBox.Show("Student Deleted.");

        }
        private void deleteLesson(int id)
        {
            Lesson lesson = db.Lesson.Find(id);
            db.Lesson.Remove(lesson);
            db.SaveChanges();
            MessageBox.Show("Lesson Deleted.");
            FillLessonComboBox(); // Dersi sildikten sonra combo box ı tekrar güncellesin ki olmayan şeyi seçmeyelim.
        }
        #endregion


        #region addButtons

        private void studentAddButton_Click(object sender, EventArgs e)
        {
            if (!txtName.Text.Equals("") & !txtSurname.Text.Equals("") & !txtAdress.Text.Equals("") & !txtPhone.Text.Equals(""))
            {
                Student student = new Student();
                student.FirstName = txtName.Text;
                student.LastName = txtSurname.Text;
                student.PhoneNumber = txtPhone.Text;
                student.Adress = txtAdress.Text;
                db.Student.Add(student);
                db.SaveChanges();
                MessageBox.Show("Student added.");

            }
            else
            {
                MessageBox.Show("Please fill the table.");
            }
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAdress.Text = string.Empty;

            studentDataGridView.DataSource = db.Student.ToList();
        }

        private void addLesson_Click(object sender, EventArgs e)
        {
            Lesson lesson = new Lesson();
            lesson.LessonName = txtLesson.Text;
            lesson.TotCredit = Convert.ToInt32(txtCredit.Text);
            db.Lesson.Add(lesson);
            db.SaveChanges();
            MessageBox.Show("Lesson Added.");
            txtLesson.Text = string.Empty;
            txtCredit.Text = string.Empty;
            var query = from x in db.Lesson
                        select new
                        {
                            x.Id,
                            x.LessonName,
                            x.TotCredit
                        };
            studentLessonGridview.DataSource = query.ToList();
            FillLessonComboBox(); // Combo box ta yeni eklediğim verileri de göstersin.

        }

        private void AddNoteToLesson(int lessonId)
        {
            int exam1 = Convert.ToInt32(txtExam1.Text);
            int exam2 = Convert.ToInt32(txtExam2.Text);
            int average = (exam1 + exam2) / 2;
            Note newNote = new Note();
            newNote.LessonId = lessonId;
            newNote.StudentId = Convert.ToInt32(txtStudentID.Text);
            newNote.Exam1 = exam1;
            newNote.Exam2 = exam2;
            newNote.Average = average;
            newNote.State = average > 50 ? "Pass" : "Fail";

            // Notu veritabanına ekle
            db.Note.Add(newNote);
            db.SaveChanges();

            MessageBox.Show($"Note added! Student {newNote.State} from lesson.");
            txtStudentID.Text = String.Empty;
            txtExam1.Text= string.Empty;
            txtExam2.Text = string.Empty;
            comboBoxLesson.ResetText();
            notesData();
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            string selectedLesson = comboBoxLesson.SelectedItem.ToString();

            int selectedLessonId = (from x in db.Lesson
                                    where x.LessonName == selectedLesson
                                    select x.Id).FirstOrDefault();

            if (selectedLessonId > 0)
            {

                AddNoteToLesson(selectedLessonId);
            }
            else
            {
                MessageBox.Show("Please select a Lesson");
            }

        }

        #endregion

        private void FillLessonComboBox()
        {
            
            var lessonNames = (from x in db.Lesson
                               select x.LessonName).ToList();

            
            comboBoxLesson.DataSource = lessonNames;
        }

        


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (passedRadio.Checked)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var result = db.Note.Where(x => x.State == "Pass" & (x.Student.FirstName == txtSearch.Text || x.Student.LastName == txtSearch.Text)).Select(x => new
                    {
                        ID=x.Id,
                        FirstName = x.Student.FirstName,
                        LastName = x.Student.LastName,
                        LessonName = x.Lesson.LessonName,
                        Exam1 = x.Exam1,
                        Exam2 = x.Exam2,
                        Average = x.Average,
                        State = x.State


                    });
                    NotesDataGridwiew.DataSource = result.ToList();


                }
                else
                {
                    var result = db.Note.Where(x => x.State == "Pass").Select(x => new
                    {
                        ID=x.Id,
                        FirstName = x.Student.FirstName,
                        LastName = x.Student.LastName,
                        LessonName = x.Lesson.LessonName,
                        Exam1 = x.Exam1,
                        Exam2 = x.Exam2,
                        Average = x.Average,
                        State = x.State


                    });
                    NotesDataGridwiew.DataSource = result.ToList();

                }
                passedRadio.Checked=false;
                
                
            }

            else if(failedRadio.Checked)
            {
                if (!txtSearch.Text.Equals(""))
                {
                    var result = db.Note.Where(x => x.State == "Fail" & (x.Student.FirstName == txtSearch.Text || x.Student.LastName == txtSearch.Text)).Select(x => new
                    {
                        ID=x.Id,
                        FirstName = x.Student.FirstName,
                        LastName = x.Student.LastName,
                        LessonName = x.Lesson.LessonName,
                        Exam1 = x.Exam1,
                        Exam2 = x.Exam2,
                        Average = x.Average,
                        State = x.State


                    });
                    NotesDataGridwiew.DataSource = result.ToList();

                   
                }
                else
                {
                    var result = db.Note.Where(x => x.State == "Fail").Select(x => new
                    {
                        ID=x.Id,
                        FirstName = x.Student.FirstName,
                        LastName = x.Student.LastName,
                        LessonName = x.Lesson.LessonName,
                        Exam1 = x.Exam1,
                        Exam2 = x.Exam2,
                        Average = x.Average,
                        State = x.State


                    });
                    NotesDataGridwiew.DataSource = result.ToList();

                }
                failedRadio.Checked = false;
            }
            else
            {
                var result = db.Note.Where(x => x.Student.FirstName == txtSearch.Text || x.Student.LastName == txtSearch.Text).Select(x => new
                {
                    ID= x.Id,
                    FirstName = x.Student.FirstName,
                    LastName = x.Student.LastName,
                    LessonName = x.Lesson.LessonName,
                    Exam1 = x.Exam1,
                    Exam2 = x.Exam2,
                    Average = x.Average,
                    State = x.State


                });
                NotesDataGridwiew.DataSource = result.ToList();

            }
        }

        private void NotesDataGridwiew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == NotesDataGridwiew.Columns["UpdateButtonColumn"].Index && e.RowIndex >= 0)
            {
                
                if (MessageBox.Show("Bu kaydı güncellemek istediğinizden emin misiniz?", "Kayıt Güncelleme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    txtNoteId.Text = NotesDataGridwiew.Rows[e.RowIndex].Cells["ID"].Value.ToString().Trim();




                }
            }

        }

        #region updateButtons

        private void updateNoteButton_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(txtNoteId.Text);
            Note note = db.Note.Find(id);
            note.Exam1 = int.Parse(txtExam1.Text);
            note.Exam2 = int.Parse(txtExam2.Text);
            note.Average = (note.Exam1 +note.Exam2)/2;
            note.State = note.Average > 50 ? "Pass" : "Fail";
            db.SaveChanges();
            MessageBox.Show("Note Updated.");
            txtExam1.Text = string.Empty;
            txtExam2.Text = string.Empty;
            txtNoteId.Text = string.Empty;
            notesData();

        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            Student student = db.Student.Find(int.Parse(txtIDStudent.Text));
            student.FirstName = txtName.Text;
            student.LastName = txtSurname.Text;
            student.PhoneNumber = txtPhone.Text;
            student.Adress = txtAdress.Text;
            db.SaveChanges();
            MessageBox.Show("Student updated.");
            studentData();

        }
        #endregion
    }
}


      

