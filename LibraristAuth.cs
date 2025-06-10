using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraristAuth : Form
    {
        public LibraristAuth()
        {
            InitializeComponent();
        }

        private void AdminAuthButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select count(1) from Библиотекари where Номер = @Login and Пароль = @Password");
            command.Parameters.AddWithValue("@Login", LoginTb.Text);
            command.Parameters.AddWithValue("@Password", PasswordMtb.Text);

            object resultObj = Database.ExecuteWithResult(command);
            int resultInt = resultObj == null ? 0 : Convert.ToInt32(resultObj);
            if (resultInt == 1)
            {
                MessageBox.Show("Вы успешно авторизованы", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LibraristAccount().Show();
                LoginTb.Clear();
                PasswordMtb.Clear();
                Hide();
            }
            else
                MessageBox.Show("Авторизация не была выполнена", "Провал", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ReturnToUserAuthButton_Click(object sender, EventArgs e)
        {
            Windows.UserAuth.Show();
            LoginTb.Clear();
            PasswordMtb.Clear();
            Hide();
        }

        private void AdminAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
