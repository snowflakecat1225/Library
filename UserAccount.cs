using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class UserAccount : Form
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void LoadUserInfo()
        {
            DataTable userInfoTable = Database.ExecuteWithTable(new SqlCommand($"select Фамилия, Имя, Отчество, Класс, Номер, Пароль from Ученики where Номер = {User.Id}"));
            LastNameTb.Text = userInfoTable.Rows[0].ItemArray[0].ToString();
            FirstNameTb.Text = userInfoTable.Rows[0].ItemArray[1].ToString();
            FatherNameTb.Text = userInfoTable.Rows[0].ItemArray[2].ToString();
            ClassTb.Text = userInfoTable.Rows[0].ItemArray[3].ToString();
            UserCodeTb.Text = userInfoTable.Rows[0].ItemArray[4].ToString();
            PasswordMtb.Text = userInfoTable.Rows[0].ItemArray[5].ToString();
        }

        private void DgvStatusCellsColor(DataGridView dgv, int index)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[index].Value.ToString() == "На чтении")
                    row.Cells[index].Style.BackColor = System.Drawing.Color.Bisque;
                else if (row.Cells[index].Value.ToString() == "Прочитано")
                    row.Cells[index].Style.BackColor = System.Drawing.Color.LightGreen;
            }
        }

        private void LoadJournal()
        {
            SqlCommand journalSearchRequest = new SqlCommand($"select Ссылка, Биография, Название, Имя as Автор, Статус from Книги, Читательский_дневник, Авторы where Книга = Серийный_номер and Автор = Номер and Ученик = {User.Id} and " +
                "(Ссылка like @Search or Биография like @Search or Название like @Search or Имя like @Search or Статус like @Search) order by Название");
            journalSearchRequest.Parameters.AddWithValue("@Search", $"%{JournalSearchTb.Text}%");
            if (!string.IsNullOrEmpty(AuthorCb1.Text))
            {
                journalSearchRequest.CommandText = journalSearchRequest.CommandText.Replace("order by Название", "and Имя = @Author order by Название");
                journalSearchRequest.Parameters.AddWithValue("@Author", AuthorCb1.Text);
            }
            if (!string.IsNullOrEmpty(StatusCb.Text))
            {
                journalSearchRequest.CommandText = journalSearchRequest.CommandText.Replace("order by Название", "and Статус = @Status order by Название");
                journalSearchRequest.Parameters.AddWithValue("@Status", StatusCb.Text);
            }
            JournalDgv.DataSource = Database.ExecuteWithTable(journalSearchRequest);
            JournalDgv.Columns[0].Visible = false;
            JournalDgv.Columns[1].Visible = false;
            DgvStatusCellsColor(JournalDgv, 4);
        }

        private void LoadBooks()
        {
            SqlCommand bookSearchRequest = new SqlCommand($"select Ссылка, Биография, Серийный_номер, Название, Издание, Имя as Автор, Жанр, Количество, Статус from Книги left join Авторы on Автор = Номер left join Читательский_дневник on Книга = Серийный_номер and Ученик = {User.Id} " +
                $"where (Серийный_номер like @Search or Ссылка like @Search or Биография like @Search or Название like @Search or Издание like @Search or Имя like @Search or Жанр like @Search or Количество like @Search or Статус like @Search) order by Название");
            bookSearchRequest.Parameters.AddWithValue("@Search", $"%{BooksSearchTb.Text}%");
            if (!string.IsNullOrEmpty(PublishingCb.Text))
            {
                bookSearchRequest.CommandText = bookSearchRequest.CommandText.Replace("order by Название", "and Издание = @Publishing order by Название");
                bookSearchRequest.Parameters.AddWithValue("@Publishing", PublishingCb.Text);
            }
            if (!string.IsNullOrEmpty(AuthorCb2.Text))
            {
                bookSearchRequest.CommandText = bookSearchRequest.CommandText.Replace("order by Название", "and Имя = @Author order by Название");
                bookSearchRequest.Parameters.AddWithValue("@Author", AuthorCb2.Text);
            }
            if (!string.IsNullOrEmpty(GenreCb.Text))
            {
                bookSearchRequest.CommandText = bookSearchRequest.CommandText.Replace("order by Название", "and Жанр = @Genre order by Название");
                bookSearchRequest.Parameters.AddWithValue("@Genre", GenreCb.Text);
            }
            BooksDgv.DataSource = Database.ExecuteWithTable(bookSearchRequest);
            BooksDgv.Columns[0].Visible = false;
            BooksDgv.Columns[1].Visible = false;
            BooksDgv.Columns[2].Visible = false;
            DgvStatusCellsColor(BooksDgv, 8);
        }

        private void LoadPublishings()
        {
            PublishingCb.DataSource = Database.ExecuteWithTable(new SqlCommand("select Издание from Книги group by Издание"));
            PublishingCb.DisplayMember = "Издание";
            PublishingCb.ValueMember = "Издание";
            PublishingCb.Text = null;
        }

        private void LoadAuthors()
        {
            DataTable authors = Database.ExecuteWithTable(new SqlCommand("select Номер, Имя from Авторы"));
            AuthorCb1.DataSource = authors;
            AuthorCb1.DisplayMember = "Имя";
            AuthorCb1.ValueMember = "Номер";
            AuthorCb1.Text = null;
            AuthorCb2.DataSource = authors;
            AuthorCb2.DisplayMember = "Имя";
            AuthorCb2.ValueMember = "Номер";
            AuthorCb2.Text = null;
        }

        private void LoadGenres()
        {
            GenreCb.DataSource = Database.ExecuteWithTable(new SqlCommand("select Жанр from Книги group by Жанр"));
            GenreCb.DisplayMember = "Жанр";
            GenreCb.ValueMember = "Жанр";
            GenreCb.Text = null;
        }

        private void LoadReadingList()
        {
            var command = new SqlCommand("select к.Название, а.Имя as Автор, с.Рекомендации from СпискиЛетнегоЧтения с join Книги к on с.Книга = к.Серийный_номер join Авторы а on к.Автор = а.Номер where с.Класс = @Class");
            command.Parameters.AddWithValue("@Class", ClassTb.Text);
            dgvReadingList.DataSource = Database.ExecuteWithTable(command);
        }

        private void UserAccountForm_Load(object sender, EventArgs e)
        {
            StatusCb.Text = null;
            LoadUserInfo();
            LoadJournal();
            LoadPublishings();
            LoadAuthors();
            LoadGenres();
            LoadReadingList();
        }

        private void Dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            switch ((sender as DataGridView).CurrentCell.OwningColumn.HeaderText)
            {
                case "Автор":
                    Process.Start((sender as DataGridView).CurrentRow.Cells[1].Value.ToString());
                    break;
                default:
                    if (string.IsNullOrEmpty((sender as DataGridView).CurrentRow.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Электронного варианта этой книги не удалось найти", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    Process.Start((sender as DataGridView).CurrentRow.Cells[0].Value.ToString());
                    break;
            }
        }

        private void Dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sender as DataGridView == JournalDgv)
                DgvStatusCellsColor(JournalDgv, 4);
            else DgvStatusCellsColor(BooksDgv, 8);
        }

        private async void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordMtb.UseSystemPasswordChar = false;
            ShowPasswordButton.Text = "Скрыть";
            await Task.Delay(3000);
            PasswordMtb.UseSystemPasswordChar = true;
            ShowPasswordButton.Text = "Показать";
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordMtb.Text))
            {
                DialogResult changePasswordQuestion =
                MessageBox.Show("Вы действительно хотите сменить пароль?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (changePasswordQuestion == DialogResult.Yes)
                {
                    SqlCommand changePasswordRequest = new SqlCommand("update Ученики set Пароль = @Password where Номер = 1");
                    changePasswordRequest.Parameters.AddWithValue("@Password", PasswordMtb.Text);
                    Database.ExecuteNonQuery(changePasswordRequest);
                }
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    LoadUserInfo();
                    LoadJournal();
                    break;
                case 1:
                    LoadBooks();
                    break;
            }
        }

        private void JournalSearchTb_TextChanged(object sender, EventArgs e)
        {
            LoadJournal();
        }

        private void BooksSearchTb_TextChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void ClassTb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            new ClassInfo(ClassTb.Text).ShowDialog();
        }

        private void ShowLibraristsButton_Click(object sender, EventArgs e)
        {
            new LibraristsInfo().ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Windows.UserAuth.Show();
            Hide();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            AuthorCb1.Text = null;
            StatusCb.Text = null;
            JournalSearchTb.Clear();
            PublishingCb.Text = null;
            AuthorCb2.Text = null;
            GenreCb.Text = null;
            BooksSearchTb.Clear();
        }

        private void BooksCbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void JournalCbs_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJournal();
        }

        private void UserAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                FileName = $"Список книг на лето ({ClassTb.Text}).pdf"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Document document = new Document(PageSize.A4, 50, 50, 25, 25);
            _ = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

            document.Open();

            FontFactory.Register("c:\\windows\\fonts\\arial.ttf");

            Font titleFont = FontFactory.GetFont("Arial", "Cp1251", true, 18f, 1);
            Paragraph title = new Paragraph($"Список книг для чтения на лето, {ClassTb.Text} класс", titleFont)
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
            command.Parameters.AddWithValue("@Class", ClassTb.Text);
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
    }
}
