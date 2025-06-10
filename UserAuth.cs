using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class UserAuth : Form
    {
        public UserAuth()
        {
            InitializeComponent();
        }

        private void UserAuthButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTb.Text) || string.IsNullOrEmpty(PasswordMtb.Text))
            {
                MessageBox.Show("Одно из полей пустое", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlCommand command = new SqlCommand("select Номер from Ученики where Номер = @Login and Пароль = @Password");
            command.Parameters.AddWithValue("@Login", LoginTb.Text);
            command.Parameters.AddWithValue("@Password", PasswordMtb.Text);

            object resultObj = Database.ExecuteWithResult(command);
            int userId = resultObj == null ? 0 : Convert.ToInt32(resultObj);
            if (userId != 0)
            {
                MessageBox.Show("Вы успешно авторизованы", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                User.Id = userId;
                new UserAccount().Show();
                LoginTb.Clear();
                PasswordMtb.Clear();
                Hide();
            }
            else
                MessageBox.Show("Авторизация не была выполнена", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AdminAuthButton_Click(object sender, EventArgs e)
        {
            Windows.LibraristAuth.Show();
            Hide();
        }
    }
}
