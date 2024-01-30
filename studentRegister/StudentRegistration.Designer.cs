
namespace studentRegister
{
    partial class StudentRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Students = new System.Windows.Forms.TabControl();
            this.StudentPage = new System.Windows.Forms.TabPage();
            this.updateStudentButton = new System.Windows.Forms.Button();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lessons = new System.Windows.Forms.TabPage();
            this.addLesson = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLesson = new System.Windows.Forms.TextBox();
            this.studentLessonGridview = new System.Windows.Forms.DataGridView();
            this.NotesTab = new System.Windows.Forms.TabPage();
            this.updateNoteButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNoteId = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.failedRadio = new System.Windows.Forms.RadioButton();
            this.passedRadio = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.NotesDataGridwiew = new System.Windows.Forms.DataGridView();
            this.addNoteButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxLesson = new System.Windows.Forms.ComboBox();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Students.SuspendLayout();
            this.StudentPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.lessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentLessonGridview)).BeginInit();
            this.NotesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGridwiew)).BeginInit();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.Controls.Add(this.StudentPage);
            this.Students.Controls.Add(this.lessons);
            this.Students.Controls.Add(this.NotesTab);
            this.Students.Location = new System.Drawing.Point(-1, 12);
            this.Students.Name = "Students";
            this.Students.SelectedIndex = 0;
            this.Students.Size = new System.Drawing.Size(1565, 755);
            this.Students.TabIndex = 0;
            // 
            // StudentPage
            // 
            this.StudentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StudentPage.Controls.Add(this.label15);
            this.StudentPage.Controls.Add(this.txtIDStudent);
            this.StudentPage.Controls.Add(this.updateStudentButton);
            this.StudentPage.Controls.Add(this.studentDataGridView);
            this.StudentPage.Controls.Add(this.studentAddButton);
            this.StudentPage.Controls.Add(this.label5);
            this.StudentPage.Controls.Add(this.txtAdress);
            this.StudentPage.Controls.Add(this.txtPhone);
            this.StudentPage.Controls.Add(this.label4);
            this.StudentPage.Controls.Add(this.label3);
            this.StudentPage.Controls.Add(this.txtSurname);
            this.StudentPage.Controls.Add(this.label2);
            this.StudentPage.Controls.Add(this.label1);
            this.StudentPage.Controls.Add(this.txtName);
            this.StudentPage.Location = new System.Drawing.Point(4, 29);
            this.StudentPage.Name = "StudentPage";
            this.StudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentPage.Size = new System.Drawing.Size(1557, 722);
            this.StudentPage.TabIndex = 0;
            this.StudentPage.Text = "Student Registration Page";
            this.StudentPage.Click += new System.EventHandler(this.StudentPage_Click);
            // 
            // updateStudentButton
            // 
            this.updateStudentButton.BackColor = System.Drawing.Color.Black;
            this.updateStudentButton.ForeColor = System.Drawing.Color.White;
            this.updateStudentButton.Location = new System.Drawing.Point(317, 445);
            this.updateStudentButton.Name = "updateStudentButton";
            this.updateStudentButton.Size = new System.Drawing.Size(86, 41);
            this.updateStudentButton.TabIndex = 11;
            this.updateStudentButton.Text = "Update";
            this.updateStudentButton.UseVisualStyleBackColor = false;
            this.updateStudentButton.Click += new System.EventHandler(this.updateStudentButton_Click);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Location = new System.Drawing.Point(453, 32);
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.RowHeadersWidth = 62;
            this.studentDataGridView.RowTemplate.Height = 28;
            this.studentDataGridView.Size = new System.Drawing.Size(1042, 546);
            this.studentDataGridView.TabIndex = 10;
            this.studentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataGridView_CellContentClick);
            // 
            // studentAddButton
            // 
            this.studentAddButton.BackColor = System.Drawing.Color.Black;
            this.studentAddButton.ForeColor = System.Drawing.Color.White;
            this.studentAddButton.Location = new System.Drawing.Point(262, 337);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(86, 41);
            this.studentAddButton.TabIndex = 9;
            this.studentAddButton.Text = "Ekle";
            this.studentAddButton.UseVisualStyleBackColor = false;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adres: ";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(126, 284);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(213, 26);
            this.txtAdress.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 222);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(213, 26);
            this.txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(126, 164);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(213, 26);
            this.txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Kayıt:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 26);
            this.txtName.TabIndex = 0;
            // 
            // lessons
            // 
            this.lessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lessons.Controls.Add(this.addLesson);
            this.lessons.Controls.Add(this.label8);
            this.lessons.Controls.Add(this.txtCredit);
            this.lessons.Controls.Add(this.label7);
            this.lessons.Controls.Add(this.label6);
            this.lessons.Controls.Add(this.txtLesson);
            this.lessons.Controls.Add(this.studentLessonGridview);
            this.lessons.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lessons.Location = new System.Drawing.Point(4, 29);
            this.lessons.Name = "lessons";
            this.lessons.Padding = new System.Windows.Forms.Padding(3);
            this.lessons.Size = new System.Drawing.Size(1557, 722);
            this.lessons.TabIndex = 1;
            this.lessons.Text = "Lessons Page";
            // 
            // addLesson
            // 
            this.addLesson.BackColor = System.Drawing.Color.Black;
            this.addLesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addLesson.Location = new System.Drawing.Point(208, 208);
            this.addLesson.Name = "addLesson";
            this.addLesson.Size = new System.Drawing.Size(73, 32);
            this.addLesson.TabIndex = 6;
            this.addLesson.Text = "Ekle";
            this.addLesson.UseVisualStyleBackColor = false;
            this.addLesson.Click += new System.EventHandler(this.addLesson_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(29, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Total Credit: ";
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(133, 159);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(148, 26);
            this.txtCredit.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(26, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "Add Lesson: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(51, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lesson:";
            // 
            // txtLesson
            // 
            this.txtLesson.Location = new System.Drawing.Point(133, 103);
            this.txtLesson.Name = "txtLesson";
            this.txtLesson.Size = new System.Drawing.Size(148, 26);
            this.txtLesson.TabIndex = 1;
            // 
            // studentLessonGridview
            // 
            this.studentLessonGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.studentLessonGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentLessonGridview.Location = new System.Drawing.Point(373, 48);
            this.studentLessonGridview.Name = "studentLessonGridview";
            this.studentLessonGridview.RowHeadersWidth = 62;
            this.studentLessonGridview.RowTemplate.Height = 28;
            this.studentLessonGridview.Size = new System.Drawing.Size(789, 514);
            this.studentLessonGridview.TabIndex = 0;
            this.studentLessonGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentLessonGridview_CellContentClick);
            // 
            // NotesTab
            // 
            this.NotesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotesTab.Controls.Add(this.updateNoteButton);
            this.NotesTab.Controls.Add(this.label14);
            this.NotesTab.Controls.Add(this.txtNoteId);
            this.NotesTab.Controls.Add(this.searchButton);
            this.NotesTab.Controls.Add(this.failedRadio);
            this.NotesTab.Controls.Add(this.passedRadio);
            this.NotesTab.Controls.Add(this.txtSearch);
            this.NotesTab.Controls.Add(this.NotesDataGridwiew);
            this.NotesTab.Controls.Add(this.addNoteButton);
            this.NotesTab.Controls.Add(this.label13);
            this.NotesTab.Controls.Add(this.label12);
            this.NotesTab.Controls.Add(this.txtExam2);
            this.NotesTab.Controls.Add(this.txtExam1);
            this.NotesTab.Controls.Add(this.label11);
            this.NotesTab.Controls.Add(this.txtStudentID);
            this.NotesTab.Controls.Add(this.label10);
            this.NotesTab.Controls.Add(this.label9);
            this.NotesTab.Controls.Add(this.comboBoxLesson);
            this.NotesTab.Location = new System.Drawing.Point(4, 29);
            this.NotesTab.Name = "NotesTab";
            this.NotesTab.Padding = new System.Windows.Forms.Padding(3);
            this.NotesTab.Size = new System.Drawing.Size(1557, 722);
            this.NotesTab.TabIndex = 2;
            this.NotesTab.Text = "Student Notes Page";
            // 
            // updateNoteButton
            // 
            this.updateNoteButton.BackColor = System.Drawing.Color.Black;
            this.updateNoteButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateNoteButton.Location = new System.Drawing.Point(272, 550);
            this.updateNoteButton.Name = "updateNoteButton";
            this.updateNoteButton.Size = new System.Drawing.Size(82, 37);
            this.updateNoteButton.TabIndex = 17;
            this.updateNoteButton.Text = "Update";
            this.updateNoteButton.UseVisualStyleBackColor = false;
            this.updateNoteButton.Click += new System.EventHandler(this.updateNoteButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(120, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "ID:";
            // 
            // txtNoteId
            // 
            this.txtNoteId.Location = new System.Drawing.Point(175, 489);
            this.txtNoteId.Name = "txtNoteId";
            this.txtNoteId.Size = new System.Drawing.Size(179, 26);
            this.txtNoteId.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Black;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(954, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 37);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // failedRadio
            // 
            this.failedRadio.AutoSize = true;
            this.failedRadio.Location = new System.Drawing.Point(787, 74);
            this.failedRadio.Name = "failedRadio";
            this.failedRadio.Size = new System.Drawing.Size(146, 24);
            this.failedRadio.TabIndex = 13;
            this.failedRadio.TabStop = true;
            this.failedRadio.Text = "Failed Students";
            this.failedRadio.UseVisualStyleBackColor = true;
            // 
            // passedRadio
            // 
            this.passedRadio.AutoSize = true;
            this.passedRadio.Location = new System.Drawing.Point(607, 74);
            this.passedRadio.Name = "passedRadio";
            this.passedRadio.Size = new System.Drawing.Size(156, 24);
            this.passedRadio.TabIndex = 12;
            this.passedRadio.TabStop = true;
            this.passedRadio.Text = "Passed Students";
            this.passedRadio.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(607, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(326, 26);
            this.txtSearch.TabIndex = 11;
            // 
            // NotesDataGridwiew
            // 
            this.NotesDataGridwiew.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotesDataGridwiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesDataGridwiew.Location = new System.Drawing.Point(487, 131);
            this.NotesDataGridwiew.Name = "NotesDataGridwiew";
            this.NotesDataGridwiew.RowHeadersWidth = 62;
            this.NotesDataGridwiew.RowTemplate.Height = 28;
            this.NotesDataGridwiew.Size = new System.Drawing.Size(1027, 477);
            this.NotesDataGridwiew.TabIndex = 10;
            this.NotesDataGridwiew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NotesDataGridwiew_CellContentClick);
            // 
            // addNoteButton
            // 
            this.addNoteButton.BackColor = System.Drawing.Color.Black;
            this.addNoteButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addNoteButton.Location = new System.Drawing.Point(272, 375);
            this.addNoteButton.Name = "addNoteButton";
            this.addNoteButton.Size = new System.Drawing.Size(82, 40);
            this.addNoteButton.TabIndex = 9;
            this.addNoteButton.Text = "Add";
            this.addNoteButton.UseVisualStyleBackColor = false;
            this.addNoteButton.Click += new System.EventHandler(this.addNoteButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(93, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Exam 2:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(93, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Exam 1:";
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(175, 313);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(179, 26);
            this.txtExam2.TabIndex = 6;
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(175, 246);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(179, 26);
            this.txtExam1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Öğrenci Numarası (Id):";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(175, 171);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(179, 26);
            this.txtStudentID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(55, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 34);
            this.label10.TabIndex = 2;
            this.label10.Text = "NOT GİRİŞİ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ders Seçiniz:";
            // 
            // comboBoxLesson
            // 
            this.comboBoxLesson.FormattingEnabled = true;
            this.comboBoxLesson.Location = new System.Drawing.Point(175, 108);
            this.comboBoxLesson.Name = "comboBoxLesson";
            this.comboBoxLesson.Size = new System.Drawing.Size(179, 28);
            this.comboBoxLesson.TabIndex = 0;
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Location = new System.Drawing.Point(111, 452);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.Size = new System.Drawing.Size(173, 26);
            this.txtIDStudent.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 13;
            this.label15.Text = "Student ID:";
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 756);
            this.Controls.Add(this.Students);
            this.Name = "StudentRegistration";
            this.Text = "StudentRegistration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.Students.ResumeLayout(false);
            this.StudentPage.ResumeLayout(false);
            this.StudentPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.lessons.ResumeLayout(false);
            this.lessons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentLessonGridview)).EndInit();
            this.NotesTab.ResumeLayout(false);
            this.NotesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotesDataGridwiew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Students;
        private System.Windows.Forms.TabPage StudentPage;
        private System.Windows.Forms.TabPage lessons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button studentAddButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.DataGridView studentLessonGridview;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLesson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addLesson;
        private System.Windows.Forms.TabPage NotesTab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLesson;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton failedRadio;
        private System.Windows.Forms.RadioButton passedRadio;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView NotesDataGridwiew;
        private System.Windows.Forms.Button updateStudentButton;
        private System.Windows.Forms.Button updateNoteButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNoteId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtIDStudent;
    }
}