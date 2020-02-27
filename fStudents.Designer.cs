namespace StudentsХml
{
    partial class fStudents
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовыйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предыдущийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМагистраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущегоСтудентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFirstName = new System.Windows.Forms.GroupBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.gbSecondName = new System.Windows.Forms.GroupBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.gbFaculty = new System.Windows.Forms.GroupBox();
            this.tbFaculty = new System.Windows.Forms.TextBox();
            this.gbDiploma = new System.Windows.Forms.GroupBox();
            this.tbDiploma = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btPrev = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lEqual = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btToPostgrStud = new System.Windows.Forms.Button();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.gbFirstName.SuspendLayout();
            this.gbSecondName.SuspendLayout();
            this.gbFaculty.SuspendLayout();
            this.gbDiploma.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(396, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.создатьНовыйСписокToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // создатьНовыйСписокToolStripMenuItem
            // 
            this.создатьНовыйСписокToolStripMenuItem.Name = "создатьНовыйСписокToolStripMenuItem";
            this.создатьНовыйСписокToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.создатьНовыйСписокToolStripMenuItem.Text = "Создать новый список";
            this.создатьНовыйСписокToolStripMenuItem.Click += new System.EventHandler(this.создатьНовыйСписокToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.следующийToolStripMenuItem,
            this.предыдущийToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.следующийToolStripMenuItem.Text = "Следующий";
            this.следующийToolStripMenuItem.Click += new System.EventHandler(this.следующийToolStripMenuItem_Click);
            // 
            // предыдущийToolStripMenuItem
            // 
            this.предыдущийToolStripMenuItem.Name = "предыдущийToolStripMenuItem";
            this.предыдущийToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.предыдущийToolStripMenuItem.Text = "Предыдущий";
            this.предыдущийToolStripMenuItem.Click += new System.EventHandler(this.предыдущийToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.добавитьМагистраToolStripMenuItem,
            this.удалитьТекущегоСтудентаToolStripMenuItem});
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить бакалавра";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьБакалавраToolStripMenuItem_Click);
            // 
            // добавитьМагистраToolStripMenuItem
            // 
            this.добавитьМагистраToolStripMenuItem.Name = "добавитьМагистраToolStripMenuItem";
            this.добавитьМагистраToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.добавитьМагистраToolStripMenuItem.Text = "Добавить магистра";
            this.добавитьМагистраToolStripMenuItem.Click += new System.EventHandler(this.добавитьМагистраToolStripMenuItem_Click);
            // 
            // удалитьТекущегоСтудентаToolStripMenuItem
            // 
            this.удалитьТекущегоСтудентаToolStripMenuItem.Name = "удалитьТекущегоСтудентаToolStripMenuItem";
            this.удалитьТекущегоСтудентаToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.удалитьТекущегоСтудентаToolStripMenuItem.Text = "Удалить текущего студента";
            this.удалитьТекущегоСтудентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущегоСтудентаToolStripMenuItem_Click);
            // 
            // gbFirstName
            // 
            this.gbFirstName.Controls.Add(this.tbFirstName);
            this.gbFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFirstName.Location = new System.Drawing.Point(0, 24);
            this.gbFirstName.Name = "gbFirstName";
            this.gbFirstName.Padding = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.gbFirstName.Size = new System.Drawing.Size(396, 53);
            this.gbFirstName.TabIndex = 1;
            this.gbFirstName.TabStop = false;
            this.gbFirstName.Text = "Имя";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFirstName.Location = new System.Drawing.Point(10, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(376, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // gbSecondName
            // 
            this.gbSecondName.Controls.Add(this.tbSecondName);
            this.gbSecondName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbSecondName.Location = new System.Drawing.Point(0, 77);
            this.gbSecondName.Name = "gbSecondName";
            this.gbSecondName.Padding = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.gbSecondName.Size = new System.Drawing.Size(396, 53);
            this.gbSecondName.TabIndex = 2;
            this.gbSecondName.TabStop = false;
            this.gbSecondName.Text = "Фамилия";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSecondName.Location = new System.Drawing.Point(10, 19);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(376, 20);
            this.tbSecondName.TabIndex = 0;
            this.tbSecondName.TextChanged += new System.EventHandler(this.tbSecondName_TextChanged);
            // 
            // gbFaculty
            // 
            this.gbFaculty.Controls.Add(this.tbFaculty);
            this.gbFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFaculty.Location = new System.Drawing.Point(0, 130);
            this.gbFaculty.Name = "gbFaculty";
            this.gbFaculty.Padding = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.gbFaculty.Size = new System.Drawing.Size(396, 53);
            this.gbFaculty.TabIndex = 3;
            this.gbFaculty.TabStop = false;
            this.gbFaculty.Text = "Факультет";
            // 
            // tbFaculty
            // 
            this.tbFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFaculty.Location = new System.Drawing.Point(10, 19);
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.Size = new System.Drawing.Size(376, 20);
            this.tbFaculty.TabIndex = 0;
            this.tbFaculty.TextChanged += new System.EventHandler(this.tbFaculty_TextChanged);
            // 
            // gbDiploma
            // 
            this.gbDiploma.Controls.Add(this.tbDiploma);
            this.gbDiploma.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDiploma.Location = new System.Drawing.Point(0, 183);
            this.gbDiploma.Name = "gbDiploma";
            this.gbDiploma.Padding = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.gbDiploma.Size = new System.Drawing.Size(396, 53);
            this.gbDiploma.TabIndex = 4;
            this.gbDiploma.TabStop = false;
            this.gbDiploma.Text = "Диплом";
            // 
            // tbDiploma
            // 
            this.tbDiploma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDiploma.Location = new System.Drawing.Point(10, 19);
            this.tbDiploma.Name = "tbDiploma";
            this.tbDiploma.Size = new System.Drawing.Size(376, 20);
            this.tbDiploma.TabIndex = 0;
            this.tbDiploma.TextChanged += new System.EventHandler(this.tbDiploma_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btPrev);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 10, 50, 10);
            this.panel1.Size = new System.Drawing.Size(396, 53);
            this.panel1.TabIndex = 5;
            // 
            // btPrev
            // 
            this.btPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btPrev.Location = new System.Drawing.Point(50, 10);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(100, 33);
            this.btPrev.TabIndex = 1;
            this.btPrev.Text = "Предыдущий";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.предыдущийToolStripMenuItem_Click);
            // 
            // btNext
            // 
            this.btNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btNext.Location = new System.Drawing.Point(246, 10);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(100, 33);
            this.btNext.TabIndex = 0;
            this.btNext.Text = "Следующий";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.следующийToolStripMenuItem_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.cbSearch);
            this.gbSearch.Controls.Add(this.lEqual);
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbSearch.Location = new System.Drawing.Point(0, 291);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Padding = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.gbSearch.Size = new System.Drawing.Size(396, 53);
            this.gbSearch.TabIndex = 6;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            this.gbSearch.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbSearch
            // 
            this.cbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(10, 19);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(165, 21);
            this.cbSearch.TabIndex = 2;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // lEqual
            // 
            this.lEqual.Location = new System.Drawing.Point(181, 22);
            this.lEqual.Name = "lEqual";
            this.lEqual.Size = new System.Drawing.Size(14, 23);
            this.lEqual.TabIndex = 1;
            this.lEqual.Text = "=";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbSearch.Location = new System.Drawing.Point(199, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(187, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btToPostgrStud
            // 
            this.btToPostgrStud.Dock = System.Windows.Forms.DockStyle.Top;
            this.btToPostgrStud.Location = new System.Drawing.Point(0, 236);
            this.btToPostgrStud.Name = "btToPostgrStud";
            this.btToPostgrStud.Size = new System.Drawing.Size(396, 33);
            this.btToPostgrStud.TabIndex = 7;
            this.btToPostgrStud.Text = "Сделать магистром";
            this.btToPostgrStud.UseVisualStyleBackColor = true;
            this.btToPostgrStud.Click += new System.EventHandler(this.btToPostgrStud_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // fStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.btToPostgrStud);
            this.Controls.Add(this.gbDiploma);
            this.Controls.Add(this.gbFaculty);
            this.Controls.Add(this.gbSecondName);
            this.Controls.Add(this.gbFirstName);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(412, 383);
            this.Name = "fStudents";
            this.Text = "Студенишки";
            this.Load += new System.EventHandler(this.fStudents_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbFirstName.ResumeLayout(false);
            this.gbFirstName.PerformLayout();
            this.gbSecondName.ResumeLayout(false);
            this.gbSecondName.PerformLayout();
            this.gbFaculty.ResumeLayout(false);
            this.gbFaculty.PerformLayout();
            this.gbDiploma.ResumeLayout(false);
            this.gbDiploma.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.GroupBox gbFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbSecondName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.GroupBox gbFaculty;
        private System.Windows.Forms.TextBox tbFaculty;
        private System.Windows.Forms.GroupBox gbDiploma;
        private System.Windows.Forms.TextBox tbDiploma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Label lEqual;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btToPostgrStud;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовыйСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМагистраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следующийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предыдущийToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущегоСтудентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

