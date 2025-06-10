namespace Library
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AuthorCb1 = new System.Windows.Forms.ComboBox();
            this.StatusCb = new System.Windows.Forms.ComboBox();
            this.ClearButton1 = new System.Windows.Forms.Button();
            this.JournalSearchTb = new System.Windows.Forms.TextBox();
            this.JournalDgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.ShowLibraristsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.FatherNameTb = new System.Windows.Forms.TextBox();
            this.PasswordMtb = new System.Windows.Forms.MaskedTextBox();
            this.ClassTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserCodeTb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenreCb = new System.Windows.Forms.ComboBox();
            this.AuthorCb2 = new System.Windows.Forms.ComboBox();
            this.ClearButton2 = new System.Windows.Forms.Button();
            this.PublishingCb = new System.Windows.Forms.ComboBox();
            this.BooksDgv = new System.Windows.Forms.DataGridView();
            this.BooksSearchTb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PrintButton = new System.Windows.Forms.Button();
            this.dgvReadingList = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDgv)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadingList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1508, 713);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1492, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Личный кабинет";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AuthorCb1);
            this.groupBox2.Controls.Add(this.StatusCb);
            this.groupBox2.Controls.Add(this.ClearButton1);
            this.groupBox2.Controls.Add(this.JournalSearchTb);
            this.groupBox2.Controls.Add(this.JournalDgv);
            this.groupBox2.Location = new System.Drawing.Point(586, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(900, 652);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // AuthorCb1
            // 
            this.AuthorCb1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthorCb1.FormattingEnabled = true;
            this.AuthorCb1.Location = new System.Drawing.Point(6, 75);
            this.AuthorCb1.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorCb1.Name = "AuthorCb1";
            this.AuthorCb1.Size = new System.Drawing.Size(364, 33);
            this.AuthorCb1.TabIndex = 20;
            this.AuthorCb1.SelectedIndexChanged += new System.EventHandler(this.JournalCbs_SelectedIndexChanged);
            // 
            // StatusCb
            // 
            this.StatusCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StatusCb.FormattingEnabled = true;
            this.StatusCb.Items.AddRange(new object[] {
            "На чтении",
            "Прочитано"});
            this.StatusCb.Location = new System.Drawing.Point(382, 75);
            this.StatusCb.Margin = new System.Windows.Forms.Padding(6);
            this.StatusCb.Name = "StatusCb";
            this.StatusCb.Size = new System.Drawing.Size(364, 33);
            this.StatusCb.TabIndex = 19;
            this.StatusCb.SelectedIndexChanged += new System.EventHandler(this.JournalCbs_SelectedIndexChanged);
            // 
            // ClearButton1
            // 
            this.ClearButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.ClearButton1.FlatAppearance.BorderSize = 0;
            this.ClearButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton1.Location = new System.Drawing.Point(758, 75);
            this.ClearButton1.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.Size = new System.Drawing.Size(136, 40);
            this.ClearButton1.TabIndex = 18;
            this.ClearButton1.Text = "Очистить";
            this.ClearButton1.UseVisualStyleBackColor = false;
            this.ClearButton1.Click += new System.EventHandler(this.Clear_Click);
            // 
            // JournalSearchTb
            // 
            this.JournalSearchTb.Dock = System.Windows.Forms.DockStyle.Top;
            this.JournalSearchTb.Location = new System.Drawing.Point(6, 30);
            this.JournalSearchTb.Margin = new System.Windows.Forms.Padding(6);
            this.JournalSearchTb.Name = "JournalSearchTb";
            this.JournalSearchTb.Size = new System.Drawing.Size(888, 31);
            this.JournalSearchTb.TabIndex = 9;
            this.JournalSearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.JournalSearchTb.TextChanged += new System.EventHandler(this.JournalSearchTb_TextChanged);
            // 
            // JournalDgv
            // 
            this.JournalDgv.AllowUserToAddRows = false;
            this.JournalDgv.AllowUserToDeleteRows = false;
            this.JournalDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JournalDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JournalDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.JournalDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.JournalDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.JournalDgv.Location = new System.Drawing.Point(6, 121);
            this.JournalDgv.Margin = new System.Windows.Forms.Padding(6);
            this.JournalDgv.MultiSelect = false;
            this.JournalDgv.Name = "JournalDgv";
            this.JournalDgv.ReadOnly = true;
            this.JournalDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.JournalDgv.Size = new System.Drawing.Size(888, 525);
            this.JournalDgv.TabIndex = 1;
            this.JournalDgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CellMouseDoubleClick);
            this.JournalDgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_ColumnHeaderMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LastNameTb);
            this.groupBox1.Controls.Add(this.ShowLibraristsButton);
            this.groupBox1.Controls.Add(this.LogoutButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ShowPasswordButton);
            this.groupBox1.Controls.Add(this.FirstNameTb);
            this.groupBox1.Controls.Add(this.ChangePasswordButton);
            this.groupBox1.Controls.Add(this.FatherNameTb);
            this.groupBox1.Controls.Add(this.PasswordMtb);
            this.groupBox1.Controls.Add(this.ClassTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.UserCodeTb);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(574, 652);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фамилия";
            // 
            // LastNameTb
            // 
            this.LastNameTb.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LastNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTb.Location = new System.Drawing.Point(258, 31);
            this.LastNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.ReadOnly = true;
            this.LastNameTb.Size = new System.Drawing.Size(306, 44);
            this.LastNameTb.TabIndex = 1;
            // 
            // ShowLibraristsButton
            // 
            this.ShowLibraristsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowLibraristsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.ShowLibraristsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowLibraristsButton.FlatAppearance.BorderSize = 0;
            this.ShowLibraristsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowLibraristsButton.Location = new System.Drawing.Point(12, 540);
            this.ShowLibraristsButton.Margin = new System.Windows.Forms.Padding(6);
            this.ShowLibraristsButton.Name = "ShowLibraristsButton";
            this.ShowLibraristsButton.Size = new System.Drawing.Size(234, 44);
            this.ShowLibraristsButton.TabIndex = 10;
            this.ShowLibraristsButton.Text = "Библиотекари";
            this.ShowLibraristsButton.UseVisualStyleBackColor = false;
            this.ShowLibraristsButton.Click += new System.EventHandler(this.ShowLibraristsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Location = new System.Drawing.Point(12, 596);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(234, 44);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Выйти из аккаунта";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Отчество";
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.ShowPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordButton.FlatAppearance.BorderSize = 0;
            this.ShowPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPasswordButton.Location = new System.Drawing.Point(256, 375);
            this.ShowPasswordButton.Margin = new System.Windows.Forms.Padding(6);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(154, 44);
            this.ShowPasswordButton.TabIndex = 7;
            this.ShowPasswordButton.Text = "Показать";
            this.ShowPasswordButton.UseVisualStyleBackColor = false;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.FirstNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameTb.Location = new System.Drawing.Point(258, 88);
            this.FirstNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.ReadOnly = true;
            this.FirstNameTb.Size = new System.Drawing.Size(306, 44);
            this.FirstNameTb.TabIndex = 2;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.ChangePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePasswordButton.FlatAppearance.BorderSize = 0;
            this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePasswordButton.Location = new System.Drawing.Point(416, 375);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(6);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(154, 44);
            this.ChangePasswordButton.TabIndex = 8;
            this.ChangePasswordButton.Text = "Изменить";
            this.ChangePasswordButton.UseVisualStyleBackColor = false;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // FatherNameTb
            // 
            this.FatherNameTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.FatherNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FatherNameTb.Location = new System.Drawing.Point(258, 146);
            this.FatherNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.FatherNameTb.Name = "FatherNameTb";
            this.FatherNameTb.ReadOnly = true;
            this.FatherNameTb.Size = new System.Drawing.Size(306, 44);
            this.FatherNameTb.TabIndex = 3;
            // 
            // PasswordMtb
            // 
            this.PasswordMtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordMtb.Location = new System.Drawing.Point(258, 319);
            this.PasswordMtb.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordMtb.Name = "PasswordMtb";
            this.PasswordMtb.Size = new System.Drawing.Size(306, 44);
            this.PasswordMtb.TabIndex = 6;
            this.PasswordMtb.UseSystemPasswordChar = true;
            // 
            // ClassTb
            // 
            this.ClassTb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassTb.Location = new System.Drawing.Point(258, 204);
            this.ClassTb.Margin = new System.Windows.Forms.Padding(4);
            this.ClassTb.Name = "ClassTb";
            this.ClassTb.ReadOnly = true;
            this.ClassTb.Size = new System.Drawing.Size(306, 44);
            this.ClassTb.TabIndex = 4;
            this.ClassTb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ClassTb_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 325);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "Пароль";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(10, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 37);
            this.label12.TabIndex = 21;
            this.label12.Text = "Класс";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(10, 267);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 37);
            this.label7.TabIndex = 23;
            this.label7.Text = "Номер билета";
            // 
            // UserCodeTb
            // 
            this.UserCodeTb.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserCodeTb.Location = new System.Drawing.Point(258, 262);
            this.UserCodeTb.Margin = new System.Windows.Forms.Padding(4);
            this.UserCodeTb.Name = "UserCodeTb";
            this.UserCodeTb.ReadOnly = true;
            this.UserCodeTb.Size = new System.Drawing.Size(306, 44);
            this.UserCodeTb.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1492, 666);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Книги";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GenreCb);
            this.groupBox3.Controls.Add(this.AuthorCb2);
            this.groupBox3.Controls.Add(this.ClearButton2);
            this.groupBox3.Controls.Add(this.PublishingCb);
            this.groupBox3.Controls.Add(this.BooksDgv);
            this.groupBox3.Controls.Add(this.BooksSearchTb);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(1480, 654);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // GenreCb
            // 
            this.GenreCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenreCb.FormattingEnabled = true;
            this.GenreCb.Location = new System.Drawing.Point(890, 75);
            this.GenreCb.Margin = new System.Windows.Forms.Padding(6);
            this.GenreCb.Name = "GenreCb";
            this.GenreCb.Size = new System.Drawing.Size(430, 33);
            this.GenreCb.TabIndex = 17;
            this.GenreCb.SelectedIndexChanged += new System.EventHandler(this.BooksCbs_SelectedIndexChanged);
            // 
            // AuthorCb2
            // 
            this.AuthorCb2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AuthorCb2.FormattingEnabled = true;
            this.AuthorCb2.Location = new System.Drawing.Point(448, 75);
            this.AuthorCb2.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorCb2.Name = "AuthorCb2";
            this.AuthorCb2.Size = new System.Drawing.Size(430, 33);
            this.AuthorCb2.TabIndex = 16;
            this.AuthorCb2.SelectedIndexChanged += new System.EventHandler(this.BooksCbs_SelectedIndexChanged);
            // 
            // ClearButton2
            // 
            this.ClearButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ClearButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.ClearButton2.FlatAppearance.BorderSize = 0;
            this.ClearButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton2.Location = new System.Drawing.Point(1336, 75);
            this.ClearButton2.Margin = new System.Windows.Forms.Padding(6);
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.Size = new System.Drawing.Size(136, 40);
            this.ClearButton2.TabIndex = 15;
            this.ClearButton2.Text = "Очистить";
            this.ClearButton2.UseVisualStyleBackColor = false;
            this.ClearButton2.Click += new System.EventHandler(this.Clear_Click);
            // 
            // PublishingCb
            // 
            this.PublishingCb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PublishingCb.FormattingEnabled = true;
            this.PublishingCb.Location = new System.Drawing.Point(6, 75);
            this.PublishingCb.Margin = new System.Windows.Forms.Padding(6);
            this.PublishingCb.Name = "PublishingCb";
            this.PublishingCb.Size = new System.Drawing.Size(430, 33);
            this.PublishingCb.TabIndex = 14;
            this.PublishingCb.SelectedIndexChanged += new System.EventHandler(this.BooksCbs_SelectedIndexChanged);
            // 
            // BooksDgv
            // 
            this.BooksDgv.AllowUserToAddRows = false;
            this.BooksDgv.AllowUserToDeleteRows = false;
            this.BooksDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BooksDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.BooksDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.BooksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.BooksDgv.Location = new System.Drawing.Point(6, 121);
            this.BooksDgv.Margin = new System.Windows.Forms.Padding(6);
            this.BooksDgv.MultiSelect = false;
            this.BooksDgv.Name = "BooksDgv";
            this.BooksDgv.ReadOnly = true;
            this.BooksDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.BooksDgv.Size = new System.Drawing.Size(1468, 527);
            this.BooksDgv.TabIndex = 2;
            this.BooksDgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_CellMouseDoubleClick);
            this.BooksDgv.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_ColumnHeaderMouseClick);
            // 
            // BooksSearchTb
            // 
            this.BooksSearchTb.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksSearchTb.Location = new System.Drawing.Point(6, 30);
            this.BooksSearchTb.Margin = new System.Windows.Forms.Padding(6);
            this.BooksSearchTb.Name = "BooksSearchTb";
            this.BooksSearchTb.Size = new System.Drawing.Size(1468, 31);
            this.BooksSearchTb.TabIndex = 1;
            this.BooksSearchTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BooksSearchTb.TextChanged += new System.EventHandler(this.BooksSearchTb_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.tabPage3.Controls.Add(this.PrintButton);
            this.tabPage3.Controls.Add(this.dgvReadingList);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1492, 666);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Книги на лето";
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(574, 612);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(6);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(344, 44);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Создать документ";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // dgvReadingList
            // 
            this.dgvReadingList.AllowUserToAddRows = false;
            this.dgvReadingList.AllowUserToDeleteRows = false;
            this.dgvReadingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReadingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReadingList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvReadingList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.dgvReadingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReadingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvReadingList.Location = new System.Drawing.Point(7, 6);
            this.dgvReadingList.Margin = new System.Windows.Forms.Padding(6);
            this.dgvReadingList.MultiSelect = false;
            this.dgvReadingList.Name = "dgvReadingList";
            this.dgvReadingList.ReadOnly = true;
            this.dgvReadingList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvReadingList.Size = new System.Drawing.Size(1478, 597);
            this.dgvReadingList.TabIndex = 2;
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(1508, 713);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(1514, 723);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.UserAccountForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JournalDgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDgv)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadingList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserCodeTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ClassTb;
        private System.Windows.Forms.TextBox FatherNameTb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.DataGridView JournalDgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox PasswordMtb;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView BooksDgv;
        private System.Windows.Forms.TextBox BooksSearchTb;
        private System.Windows.Forms.TextBox JournalSearchTb;
        private System.Windows.Forms.Button ShowLibraristsButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox GenreCb;
        private System.Windows.Forms.ComboBox AuthorCb2;
        private System.Windows.Forms.Button ClearButton2;
        private System.Windows.Forms.ComboBox PublishingCb;
        private System.Windows.Forms.ComboBox AuthorCb1;
        private System.Windows.Forms.ComboBox StatusCb;
        private System.Windows.Forms.Button ClearButton1;
        private System.Windows.Forms.DataGridView dgvReadingList;
        private System.Windows.Forms.Button PrintButton;
    }
}