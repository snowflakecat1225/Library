using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraristAccount : Form
    {
        public LibraristAccount()
        {
            InitializeComponent();
        }

        private void LoadJournals()
        {
            SqlCommand journalsSearchRequest = new SqlCommand("select Код, u.Номер, Серийный_номер, Фамилия + ' ' + u.Имя + ' ' + Отчество as Ученик, Название + ' (' + a.Имя + ')' as Книга, Взята, Отдана, Статус from Читательский_дневник, Книги, Ученики u, Авторы a where Ученик = u.Номер and Книга = Серийный_номер and Автор = a.Номер and " +
                "(u.Номер like @Search or Серийный_номер like @Search or Фамилия like @Search or u.Имя like @Search or Отчество like @Search or Название like @Search or a.Имя like @Search or Взята like @Search or Отдана like @Search or Статус like @Search)");
            journalsSearchRequest.Parameters.AddWithValue("@Search", $"%{JournalsSearchTb.Text}%");
            JournalsDgv.DataSource = Database.ExecuteWithTable(journalsSearchRequest);
            JournalsDgv.Columns[0].Visible = false;
            JournalsDgv.Columns[1].Visible = false;
            JournalsDgv.Columns[2].Visible = false;
            PupilsCb.SelectedIndex = -1;
            BooksCb.SelectedIndex = -1;
            BookWasBroughtDtp.Value = DateTime.Now;
            BookWasReturnedChb.Checked = false;
            BookWasReturnedDtp.Value = DateTime.Now;
            BookStatusCb.SelectedIndex = 0;
        }

        private void LoadPupils()
        {
            SqlCommand pupilsSearchRequest = new SqlCommand("select * from Ученики where Фамилия like @Search or Имя like @Search or Отчество like @Search or Класс like @Search or Пароль like @Search");
            pupilsSearchRequest.Parameters.AddWithValue("@Search", $"%{PupilsSearchTb.Text}%");
            PupilsDgv.DataSource = Database.ExecuteWithTable(pupilsSearchRequest);
            PupilsDgv.Columns[0].Visible = false;
            PupilsDgv.Columns[5].Visible = false;
            PupilsCb.Items.Clear();
            foreach (DataGridViewRow row in PupilsDgv.Rows)
                PupilsCb.Items.Add($"{row.Cells[1].Value} {row.Cells[2].Value} {row.Cells[3].Value}");
            LastNamePupilTb.Clear();
            FirstNamePupilTb.Clear();
            FatherNamePupilTb.Clear();
            PupilClassesCb.SelectedIndex = -1;
            PupilPasswordMtb.Clear();
        }

        private void LoadClasses()
        {
            SqlCommand classesSearchRequest = new SqlCommand("select N as Класс, Руководитель from Классы where N like @Search or Руководитель like @Search");
            classesSearchRequest.Parameters.AddWithValue("@Search", $"%{ClassesSearchTb.Text}%");
            ClassesDgv.DataSource = Database.ExecuteWithTable(classesSearchRequest);
            PupilClassesCb.Items.Clear();
            foreach (DataGridViewRow row in ClassesDgv.Rows)
                PupilClassesCb.Items.Add(row.Cells[0].Value.ToString());
            ClassTb.Clear();
            TeacherTb.Clear();
        }

        private void LoadBooks()
        {
            SqlCommand booksSearchRequest = new SqlCommand("select Серийный_номер, Название, Издание, Имя, Жанр, Количество, Ссылка from Книги, Авторы where Автор = Номер and " +
                "(Серийный_номер like @Search or Название like @Search or Издание like @Search or Имя like @Search or Жанр like @Search or Количество like @Search or Ссылка like @Search)");
            booksSearchRequest.Parameters.AddWithValue("@Search", $"%{BooksSearchTb.Text}%");
            BooksDgv.DataSource = Database.ExecuteWithTable(booksSearchRequest);
            BooksDgv.Columns[0].Visible = false;
            BooksDgv.Columns[6].Visible = false;
            BooksCb.Items.Clear();
            foreach (DataGridViewRow row in BooksDgv.Rows)
                BooksCb.Items.Add($"{row.Cells[1].Value} ({row.Cells[3].Value})");
            BookTitleTb.Clear();
            BookPublishingTb.Clear();
            BookAuthorCb.SelectedIndex = -1;
            BookGenreTb.Clear();
            BooksCountNud.Value = 0;
            BookLinkTb.Clear();
        }

        private void LoadReadingList()
        {
            var command = new SqlCommand("select к.Серийный_номер, к.Название, а.Имя as Автор, с.Рекомендации from СпискиЛетнегоЧтения с join Книги к on с.Книга = к.Серийный_номер join Авторы а on к.Автор = а.Номер where с.Класс = @Class and " +
                "(к.Серийный_номер like @Search or а.Имя like @Search or с.Рекомендации like @Search)");
            command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
            command.Parameters.AddWithValue("@Search", $"%{ReadingListSearchTb.Text}%");
            dgvReadingList.DataSource = Database.ExecuteWithTable(command);
            dgvReadingList.Columns[0].Visible = false;
        }

        private void LoadAvailableBooks()
        {
            var command = new SqlCommand("select к.Серийный_номер, к.Название + ' (' + а.Имя + ')' as КнигаАвтор from Книги к join Авторы а on к.Автор = а.Номер where к.Серийный_номер not in (select Книга from СпискиЛетнегоЧтения where Класс = @Class)");
            command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
            AvailableBooksCb.DataSource = Database.ExecuteWithTable(command);
            AvailableBooksCb.DisplayMember = "КнигаАвтор";
            AvailableBooksCb.ValueMember = "Серийный_номер";
        }

        private void LoadAuthors()
        {
            SqlCommand authorsSearchRequest = new SqlCommand("select * from Авторы where Имя like @Search or Биография like @Search");
            authorsSearchRequest.Parameters.AddWithValue("@Search", $"%{SearchAuthorTb.Text}%");
            AuthorsDgv.DataSource = Database.ExecuteWithTable(authorsSearchRequest);
            AuthorsDgv.Columns[0].Visible = false;
            AuthorsDgv.Columns[2].Visible = false;
            BookAuthorCb.Items.Clear();
            foreach (DataGridViewRow row in AuthorsDgv.Rows)
                BookAuthorCb.Items.Add(row.Cells[1].Value);
            AuthorTb.Clear();
            AuthorBiographyTb.Clear();
        }

        private void LibraristAccount_Load(object sender, EventArgs e)
        {
            OneMoreClassCb.DataSource = Database.ExecuteWithTable(new SqlCommand("select N from Классы"));
            OneMoreClassCb.DisplayMember = "N";
            OneMoreClassCb.ValueMember = "N";
            LoadJournals();
            LoadPupils();
            LoadClasses();
            LoadBooks();
            LoadAuthors();
        }

        private void JournalsDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PupilsCb.SelectedIndex = Convert.ToInt32(JournalsDgv.CurrentRow.Cells[1].Value) - 1;
            BooksCb.SelectedIndex = Convert.ToInt32(JournalsDgv.CurrentRow.Cells[2].Value) - 1;
            BookWasBroughtDtp.Value = Convert.ToDateTime(JournalsDgv.CurrentRow.Cells[5].Value);
            if (!string.IsNullOrEmpty(JournalsDgv.CurrentRow.Cells[6].Value.ToString()))
            {
                BookWasReturnedChb.Checked = true;
                BookWasReturnedDtp.Value = Convert.ToDateTime(JournalsDgv.CurrentRow.Cells[6].Value);
            }
            else BookWasReturnedChb.Checked = false;
        }

        private void PupilsDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LastNamePupilTb.Text = PupilsDgv.CurrentRow.Cells[1].Value.ToString();
            FirstNamePupilTb.Text = PupilsDgv.CurrentRow.Cells[2].Value.ToString();
            FatherNamePupilTb.Text = PupilsDgv.CurrentRow.Cells[3].Value.ToString();
            PupilClassesCb.SelectedIndex = PupilClassesCb.Items.IndexOf(PupilsDgv.CurrentRow.Cells[4].Value.ToString());
            PupilPasswordMtb.Text = PupilsDgv.CurrentRow.Cells[5].Value.ToString();
        }

        private void ClassesDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClassTb.Text = ClassesDgv.CurrentRow.Cells[0].Value.ToString();
            TeacherTb.Text = ClassesDgv.CurrentRow.Cells[1].Value.ToString();
        }

        private void BooksDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookTitleTb.Text = BooksDgv.CurrentRow.Cells[1].Value.ToString();
            BookPublishingTb.Text = BooksDgv.CurrentRow.Cells[2].Value.ToString();
            BookAuthorCb.Text = BooksDgv.CurrentRow.Cells[3].Value.ToString();
            BookGenreTb.Text = BooksDgv.CurrentRow.Cells[4].Value.ToString();
            BooksCountNud.Value = Convert.ToInt32(BooksDgv.CurrentRow.Cells[5].Value);
            BookLinkTb.Text = BooksDgv.CurrentRow.Cells[6].Value.ToString();
        }

        private void AuthorsDgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AuthorTb.Text = AuthorsDgv.CurrentRow.Cells[1].Value.ToString();
            AuthorBiographyTb.Text = AuthorsDgv.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvReadingList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            NoteTb.Text = dgvReadingList.CurrentRow.Cells[3].Value.ToString();
        }

        private void OneMoreClassCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReadingList();
            LoadAvailableBooks();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Читательские дневники":
                    if (string.IsNullOrEmpty(PupilsCb.Text) || string.IsNullOrEmpty(BooksCb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand booksCount = new SqlCommand("select Количество from Книги where Серийный_номер = @Book");
                    booksCount.Parameters.AddWithValue("@Book", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                    int booksCountGay = Convert.ToInt32(Database.ExecuteWithResult(booksCount));
                    if (BookStatusCb.Text == "На чтении" && booksCountGay == 0)
                    {
                        MessageBox.Show("К сожалению экземпляры этой книги закончились", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand addJournalRequest = new SqlCommand("insert into Читательский_дневник values (@Pupil, @Book, @BroughtDt, @ReturnedDt, @Status)");
                    addJournalRequest.Parameters.AddWithValue("@Pupil", PupilsCb.Items.IndexOf(PupilsCb.Text) + 1);
                    addJournalRequest.Parameters.AddWithValue("@Book", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                    addJournalRequest.Parameters.AddWithValue("@BroughtDt", BookWasBroughtDtp.Value);
                    if (BookWasReturnedChb.Checked)
                        addJournalRequest.Parameters.AddWithValue("@ReturnedDt", BookWasReturnedDtp.Value);
                    else
                        addJournalRequest.Parameters.AddWithValue("@ReturnedDt", DBNull.Value);
                    addJournalRequest.Parameters.AddWithValue("@Status", BookStatusCb.Text);
                    Database.ExecuteNonQuery(addJournalRequest);

                    if (BookStatusCb.Text == "На чтении")
                    {
                        SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                        updateBookCountRequest.Parameters.AddWithValue("@Count", booksCountGay - 1);
                        updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                        Database.ExecuteNonQuery(updateBookCountRequest);
                    }
                    LoadJournals();
                    LoadBooks();

                    break;
                case "Ученики":
                    if (string.IsNullOrEmpty(LastNamePupilTb.Text) || string.IsNullOrEmpty(FirstNamePupilTb.Text) || string.IsNullOrEmpty(FatherNamePupilTb.Text) || PupilClassesCb.SelectedIndex == -1 || string.IsNullOrEmpty(PupilPasswordMtb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand addPupilRequest = new SqlCommand("insert into Ученики values (@LastName, @FirstName, @FatherName, @Class, @Password)");
                    addPupilRequest.Parameters.AddWithValue("@LastName", LastNamePupilTb.Text);
                    addPupilRequest.Parameters.AddWithValue("@FirstName", FirstNamePupilTb.Text);
                    addPupilRequest.Parameters.AddWithValue("@FatherName", FatherNamePupilTb.Text);
                    addPupilRequest.Parameters.AddWithValue("@Class", PupilClassesCb.Text);
                    addPupilRequest.Parameters.AddWithValue("@Password", PupilPasswordMtb.Text);
                    Database.ExecuteNonQuery(addPupilRequest);
                    LoadPupils();

                    break;
                case "Классы":
                    if (string.IsNullOrEmpty(ClassTb.Text) || string.IsNullOrEmpty(TeacherTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand addClassRequest = new SqlCommand("insert into Классы values (@Class, @Teacher)");
                    addClassRequest.Parameters.AddWithValue("@Class", ClassTb.Text);
                    addClassRequest.Parameters.AddWithValue("@Teacher", TeacherTb.Text);
                    Database.ExecuteNonQuery(addClassRequest);
                    LoadClasses();

                    break;
                case "Книги":
                    if (string.IsNullOrEmpty(BookTitleTb.Text) || string.IsNullOrEmpty(BookPublishingTb.Text) || string.IsNullOrEmpty(BookAuthorCb.Text) || string.IsNullOrEmpty(BookGenreTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (!string.IsNullOrEmpty(BookLinkTb.Text))
                    {
                        try
                        {
                            Uri uri = new Uri(BookLinkTb.Text);
                            string host = uri.Host;
                            int port = uri.Port == -1 ? 554 : uri.Port;

                            using (TcpClient client = new TcpClient())
                                client.Connect(host, port);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    SqlCommand addBookRequest = new SqlCommand("insert into Книги values (@Title, @Publishing, @Author, @Genre, @Count, @Link)");
                    addBookRequest.Parameters.AddWithValue("@Title", BookTitleTb.Text);
                    addBookRequest.Parameters.AddWithValue("@Publishing", BookPublishingTb.Text);
                    addBookRequest.Parameters.AddWithValue("@Author", BookAuthorCb.Items.IndexOf(BookAuthorCb.Text) + 1);
                    addBookRequest.Parameters.AddWithValue("@Genre", BookGenreTb.Text);
                    addBookRequest.Parameters.AddWithValue("@Count", BooksCountNud.Value);
                    if (string.IsNullOrEmpty(BookLinkTb.Text))
                        addBookRequest.Parameters.AddWithValue("@Link", DBNull.Value);
                    else
                        addBookRequest.Parameters.AddWithValue("@Link", BookLinkTb.Text);
                    Database.ExecuteNonQuery(addBookRequest);
                    LoadBooks();
                    
                    break;
                case "Авторы":
                    if (string.IsNullOrEmpty(AuthorTb.Text) || string.IsNullOrEmpty(AuthorBiographyTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    {
                        Uri uri = new Uri(AuthorBiographyTb.Text);
                        string host = uri.Host;
                        int port = uri.Port == -1 ? 80 : uri.Port;

                        using (TcpClient client = new TcpClient())
                            client.Connect(host, port);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand addAuthorRequest = new SqlCommand("insert into Авторы values (@Name, @Biography)");
                    addAuthorRequest.Parameters.AddWithValue("@Name", AuthorTb.Text);
                    addAuthorRequest.Parameters.AddWithValue("@Biography", AuthorBiographyTb.Text);
                    Database.ExecuteNonQuery(addAuthorRequest);
                    LoadAuthors();

                    break;
                case "Книги на лето":
                    if (AvailableBooksCb.SelectedItem == null || OneMoreClassCb.SelectedValue == null)
                    {
                        MessageBox.Show("Выберите класс и книгу");
                        return;
                    }

                    var command = new SqlCommand("insert into СпискиЛетнегоЧтения (Класс, Книга, Рекомендации) values (@Class, @Book, @Notes)");
                    command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
                    command.Parameters.AddWithValue("@Book", Convert.ToInt32(AvailableBooksCb.SelectedValue));
                    if (string.IsNullOrEmpty(NoteTb.Text))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", NoteTb.Text);
                    Database.ExecuteNonQuery(command);

                    LoadReadingList();
                    LoadAvailableBooks();
                    break;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Читательские дневники":
                    if (JournalsDgv.CurrentRow == null)
                        break;

                    if (string.IsNullOrEmpty(PupilsCb.Text) || string.IsNullOrEmpty(BooksCb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (BookStatusCb.Text == "На чтении" && Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select Количество from Книги where Серийный_номер = " + (BooksCb.Items.IndexOf(BooksCb.Text) + 1)))) == 0)
                    {
                        MessageBox.Show("К сожалению экземпляры этой книги закончились", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand updateJournalRequest = new SqlCommand("update Читательский_дневник set Ученик = @Pupil, Книга = @Book, Взята = @BroughtDt, Отдана = @ReturnedDt, Статус = @Status where Код = @Code");
                    updateJournalRequest.Parameters.AddWithValue("@Pupil", PupilsCb.Items.IndexOf(PupilsCb.Text) + 1);
                    updateJournalRequest.Parameters.AddWithValue("@Book", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                    updateJournalRequest.Parameters.AddWithValue("@BroughtDt", BookWasBroughtDtp.Value);
                    if (BookWasReturnedChb.Checked)
                        updateJournalRequest.Parameters.AddWithValue("@ReturnedDt", BookWasReturnedDtp.Value);
                    else
                        updateJournalRequest.Parameters.AddWithValue("@ReturnedDt", DBNull.Value);
                    updateJournalRequest.Parameters.AddWithValue("@Status", BookStatusCb.Text);
                    updateJournalRequest.Parameters.AddWithValue("@Code", JournalsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(updateJournalRequest);

                    if (Convert.ToInt32(JournalsDgv.CurrentRow.Cells["Серийный_номер"].Value) == BooksCb.Items.IndexOf(BooksCb.Text) + 1)
                    {
                        if (JournalsDgv.CurrentRow.Cells["Статус"].Value.ToString() == "Прочитано" && BookStatusCb.Text == "На чтении")
                        {
                            SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                            updateBookCountRequest.Parameters.AddWithValue("@Count", Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select Количество from Книги where Серийный_номер = " + (BooksCb.Items.IndexOf(BooksCb.Text) + 1)))) - 1);
                            updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                            Database.ExecuteNonQuery(updateBookCountRequest);
                        }
                        else if (JournalsDgv.CurrentRow.Cells["Статус"].Value.ToString() == "На чтении" && BookStatusCb.Text == "Прочитано")
                        {
                            SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                            updateBookCountRequest.Parameters.AddWithValue("@Count", Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select Количество from Книги where Серийный_номер = " + (BooksCb.Items.IndexOf(BooksCb.Text) + 1)))) + 1);
                            updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                            Database.ExecuteNonQuery(updateBookCountRequest);
                        }
                    }
                    else
                    {
                        if (JournalsDgv.CurrentRow.Cells["Статус"].Value.ToString() == "На чтении")
                        {
                            SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                            updateBookCountRequest.Parameters.AddWithValue("@Count", Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select Количество from Книги where Серийный_номер = " + JournalsDgv.CurrentRow.Cells["Серийный_номер"].Value))) + 1);
                            updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", JournalsDgv.CurrentRow.Cells["Серийный_номер"].Value);
                            Database.ExecuteNonQuery(updateBookCountRequest);
                        }
                        if (BookStatusCb.Text == "На чтении")
                        {
                            SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                            updateBookCountRequest.Parameters.AddWithValue("@Count", Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select Количество from Книги where Серийный_номер = " + (BooksCb.Items.IndexOf(BooksCb.Text) + 1)))) - 1);
                            updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                            Database.ExecuteNonQuery(updateBookCountRequest);
                        }
                    }
                    LoadJournals();
                    LoadBooks();

                    break;
                case "Ученики":
                    if (PupilsDgv.CurrentRow == null)
                        break;

                    if (string.IsNullOrEmpty(LastNamePupilTb.Text) || string.IsNullOrEmpty(FirstNamePupilTb.Text) || string.IsNullOrEmpty(FatherNamePupilTb.Text) || PupilClassesCb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand updatePupilRequest = new SqlCommand("update Ученики set Фамилия = @LastName, Имя = @FirstName, Отчество = @FatherName, Класс = @Class, Пароль = @Password where Номер = @Number");
                    updatePupilRequest.Parameters.AddWithValue("@LastName", LastNamePupilTb.Text);
                    updatePupilRequest.Parameters.AddWithValue("@FirstName", FirstNamePupilTb.Text);
                    updatePupilRequest.Parameters.AddWithValue("@FatherName", FatherNamePupilTb.Text);
                    updatePupilRequest.Parameters.AddWithValue("@Class", PupilClassesCb.Text);
                    updatePupilRequest.Parameters.AddWithValue("@Password", PupilPasswordMtb.Text);
                    updatePupilRequest.Parameters.AddWithValue("@Number", PupilsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(updatePupilRequest);
                    LoadPupils();

                    break;
                case "Классы":
                    if (ClassesDgv.CurrentRow == null)
                        break;

                    if (string.IsNullOrEmpty(ClassTb.Text) || string.IsNullOrEmpty(TeacherTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand updateClassRequest = new SqlCommand("update Классы set N = @Class, Руководитель = @Teacher where N = @N");
                    updateClassRequest.Parameters.AddWithValue("@Class", ClassTb.Text);
                    updateClassRequest.Parameters.AddWithValue("@Teacher", TeacherTb.Text);
                    updateClassRequest.Parameters.AddWithValue("@N", ClassesDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(updateClassRequest);
                    LoadClasses();

                    break;
                case "Книги":
                    if (BooksDgv.CurrentRow == null)
                        break;

                    if (string.IsNullOrEmpty(BookTitleTb.Text) || string.IsNullOrEmpty(BookPublishingTb.Text) || string.IsNullOrEmpty(BookAuthorCb.Text) || string.IsNullOrEmpty(BookGenreTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    if (!string.IsNullOrEmpty(BookLinkTb.Text))
                    {
                        try
                        {
                            Uri uri = new Uri(BookLinkTb.Text);
                            string host = uri.Host;
                            int port = uri.Port == -1 ? 554 : uri.Port;

                            using (TcpClient client = new TcpClient())
                                client.Connect(host, port);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }

                    SqlCommand updateBookRequest = new SqlCommand("update Книги set Название = @Title, Издание = @Publishing, Автор = @Author, Жанр = @Genre, Количество = @Count, Ссылка = @Link where Серийный_номер = @SerialNumber");
                    updateBookRequest.Parameters.AddWithValue("@Title", BookTitleTb.Text);
                    updateBookRequest.Parameters.AddWithValue("@Publishing", BookPublishingTb.Text);
                    updateBookRequest.Parameters.AddWithValue("@Author", BookAuthorCb.Items.IndexOf(BookAuthorCb.Text) + 1);
                    updateBookRequest.Parameters.AddWithValue("@Genre", BookGenreTb.Text);
                    updateBookRequest.Parameters.AddWithValue("@Count", BooksCountNud.Value);
                    if (string.IsNullOrEmpty(BookLinkTb.Text))
                        updateBookRequest.Parameters.AddWithValue("@Link", DBNull.Value);
                    else
                        updateBookRequest.Parameters.AddWithValue("@Link", BookLinkTb.Text);
                    updateBookRequest.Parameters.AddWithValue("@SerialNumber", BooksDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(updateBookRequest);
                    LoadBooks();

                    break;
                case "Авторы":
                    if (AuthorsDgv.CurrentRow == null)
                        break;

                    if (string.IsNullOrEmpty(AuthorTb.Text) || string.IsNullOrEmpty(AuthorBiographyTb.Text))
                    {
                        MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    try
                    {
                        Uri uri = new Uri(AuthorBiographyTb.Text);
                        string host = uri.Host;
                        int port = uri.Port == -1 ? 80 : uri.Port;

                        using (TcpClient client = new TcpClient())
                            client.Connect(host, port);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    SqlCommand updateAuthorRequest = new SqlCommand("update Авторы set Имя = @Name, Биография = @Biography where Номер = @Number");
                    updateAuthorRequest.Parameters.AddWithValue("@Name", AuthorTb.Text);
                    updateAuthorRequest.Parameters.AddWithValue("@Biography", AuthorBiographyTb.Text);
                    updateAuthorRequest.Parameters.AddWithValue("@Number", AuthorsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(updateAuthorRequest);
                    LoadAuthors();

                    break;
                case "Книги на лето":
                    if (dgvReadingList.CurrentRow == null)
                    {
                        MessageBox.Show("Выберите книгу для удаления");
                        return;
                    }

                    if (OneMoreClassCb.SelectedValue == null)
                    {
                        MessageBox.Show("Выберите класс");
                        return;
                    }

                    var command = new SqlCommand("update СпискиЛетнегоЧтения set Рекомендации = @Notes where Класс = @Class and Книга = @Book");
                    command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
                    command.Parameters.AddWithValue("@Book", Convert.ToInt32(dgvReadingList.CurrentRow.Cells[0].Value));
                    if (string.IsNullOrEmpty(NoteTb.Text))
                        command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        command.Parameters.AddWithValue("@Notes", NoteTb.Text);
                    Database.ExecuteNonQuery(command);

                    LoadReadingList();
                    LoadAvailableBooks();
                    break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Читательские дневники":
                    if (JournalsDgv.CurrentRow == null)
                        break;

                    SqlCommand deleteJournalRequest = new SqlCommand("delete from Читательский_дневник where Код = @Code");
                    deleteJournalRequest.Parameters.AddWithValue("@Code", JournalsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(deleteJournalRequest);

                    if (Convert.ToInt32(Database.ExecuteWithResult(new SqlCommand("select count(1) from Читательский_дневник where Код = " + JournalsDgv.CurrentRow.Cells[0].Value))) == 0)
                    {
                        if (MessageBox.Show("Изменить число книг?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (JournalsDgv.CurrentRow.Cells["Статус"].Value.ToString() == "На чтении")
                            {
                                SqlCommand booksCount = new SqlCommand("select Количество from Книги where Серийный_номер = @Book");
                                booksCount.Parameters.AddWithValue("@Book", JournalsDgv.CurrentRow.Cells["Серийный_номер"]);
                                SqlCommand updateBookCountRequest = new SqlCommand("update Книги set Количество = @Count where Серийный_номер = @SerialNumber");
                                updateBookCountRequest.Parameters.AddWithValue("@Count", Convert.ToInt32(Database.ExecuteWithResult(booksCount)) + 1);
                                updateBookCountRequest.Parameters.AddWithValue("@SerialNumber", BooksCb.Items.IndexOf(BooksCb.Text) + 1);
                                Database.ExecuteNonQuery(updateBookCountRequest);
                            }
                        }
                    }
                    LoadJournals();
                    LoadBooks();

                    break;
                case "Ученики":
                    if (PupilsDgv.CurrentRow == null)
                        break;

                    SqlCommand deletePupilRequest = new SqlCommand("delete from Ученики where Номер = @Number");
                    deletePupilRequest.Parameters.AddWithValue("@Number", PupilsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(deletePupilRequest);
                    LoadPupils();

                    break;
                case "Классы":
                    if (ClassesDgv.CurrentRow == null)
                        break;

                    SqlCommand deleteClassRequest = new SqlCommand("delete from Классы where N = @N");
                    deleteClassRequest.Parameters.AddWithValue("@N", ClassesDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(deleteClassRequest);
                    LoadClasses();

                    break;
                case "Книги":
                    if (BooksDgv.CurrentRow == null)
                        break;

                    SqlCommand deleteBookRequest = new SqlCommand("delete from Книги where Серийный_номер = @SerialNumber");
                    deleteBookRequest.Parameters.AddWithValue("@SerialNumber", BooksDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(deleteBookRequest);
                    LoadBooks();

                    break;
                case "Авторы":
                    if (AuthorsDgv.CurrentRow == null)
                        break;

                    SqlCommand deleteAuthorRequest = new SqlCommand("delete from Авторы where Номер = @Number");
                    deleteAuthorRequest.Parameters.AddWithValue("@Number", AuthorsDgv.CurrentRow.Cells[0].Value);
                    Database.ExecuteNonQuery(deleteAuthorRequest);
                    LoadAuthors();

                    break;
                case "Книги на лето":
                    if (dgvReadingList.CurrentRow == null)
                    {
                        MessageBox.Show("Выберите книгу для удаления");
                        return;
                    }

                    if (OneMoreClassCb.SelectedValue == null)
                    {
                        MessageBox.Show("Выберите класс");
                        return;
                    }

                    var command = new SqlCommand("delete from СпискиЛетнегоЧтения where Класс = @Class and Книга = @Book");
                    command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
                    command.Parameters.AddWithValue("@Book", Convert.ToInt32(dgvReadingList.CurrentRow.Cells[0].Value));
                    Database.ExecuteNonQuery(command);

                    LoadReadingList();
                    LoadAvailableBooks();
                    break;
            }
        }

        private void BookWasReturnedChb_CheckedChanged(object sender, EventArgs e)
        {
            BookWasReturnedDtp.Enabled = BookWasReturnedChb.Checked;
            if (BookWasReturnedChb.Checked)
            {
                BookStatusCb.Items.Clear();
                BookStatusCb.Text = "Прочитано";
                BookStatusCb.Items.Add(BookStatusCb.Text);
            }
            else
            {
                BookStatusCb.Items.Clear();
                BookStatusCb.Text = "На чтении";
                BookStatusCb.Items.Add(BookStatusCb.Text);
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            LoadJournals();
            LoadPupils();
            LoadClasses();
            LoadBooks();
            LoadAuthors();
            LoadReadingList();
        }

        private void OpenBookLinkButton_Click(object sender, EventArgs e)
        {
            if (BooksDgv.CurrentRow != null)
                Process.Start(BooksDgv.CurrentRow.Cells[6].Value.ToString());
        }

        private void OpenBiographyLinkButton_Click(object sender, EventArgs e)
        {
            if (AuthorsDgv.CurrentRow != null)
                Process.Start(AuthorsDgv.CurrentRow.Cells[2].Value.ToString());
        }

        private void ShowEntireClassInfoButton_Click(object sender, EventArgs e)
        {
            new ClassInfo(ClassesDgv.CurrentRow.Cells[0].Value.ToString()).ShowDialog();
        }

        private void AddCell(PdfPTable table, string text, Font font, bool centered = false)
        {
            table.AddCell(new PdfPCell(new Phrase(text, font))
            {
                Padding = 5,
                BorderWidth = 0.5f,
                HorizontalAlignment = centered ? Element.ALIGN_CENTER : Element.ALIGN_LEFT
            });
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Сохранить список книг для чтения на лето",
                FileName = $"Список книг на лето ({OneMoreClassCb.Text}).pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Document document = new Document(PageSize.A4, 50, 50, 25, 25);
            _ = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

            document.Open();

            FontFactory.Register("c:\\windows\\fonts\\arial.ttf");

            Font titleFont = FontFactory.GetFont("Arial", "Cp1251", true, 18f, 1);
            Paragraph title = new Paragraph($"Список книг для чтения на лето, {OneMoreClassCb.Text} класс", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            document.Add(title);

            Font dateFont = FontFactory.GetFont("Arial", "Cp1251", true, 10f, 2);
            Paragraph date = new Paragraph($"Сформировано: {DateTime.Now:dd.MM.yyyy}", dateFont)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingAfter = 20
            };
            document.Add(date);

            PdfPTable table = new PdfPTable(3)
            {
                WidthPercentage = 100
            };
            table.SetWidths(new float[] { 3, 2, 3 });

            Font headerFont = FontFactory.GetFont("Arial", "Cp1251", true, 12f, 1);
            AddCell(table, "Название книги", headerFont, true);
            AddCell(table, "Автор", headerFont, true);
            AddCell(table, "Рекомендации", headerFont, true);

            var command = new SqlCommand("select к.Название, а.Имя as Автор, с.Рекомендации from СпискиЛетнегоЧтения с join Книги к on с.Книга = к.Серийный_номер join Авторы а on к.Автор = а.Номер where с.Класс = @Class order by к.Название");
            command.Parameters.AddWithValue("@Class", OneMoreClassCb.Text);
            var books = Database.ExecuteWithTable(command);

            Font cellFont = FontFactory.GetFont("Arial", "Cp1251", true, 10f, 0);

            foreach (DataRow book in books.Rows)
            {
                AddCell(table, book.ItemArray[0].ToString(), cellFont);
                AddCell(table, book.ItemArray[1].ToString(), cellFont);
                AddCell(table, book.ItemArray[2].ToString(), cellFont);
            }

            document.Add(table);
            document.Close();

            MessageBox.Show($"Список успешно сохранен как {saveFileDialog.FileName}", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Windows.LibraristAuth.Show();
            Hide();
        }

        private void AdminAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
