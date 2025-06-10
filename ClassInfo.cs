using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Library
{
    public partial class ClassInfo : Form
    {
        private static string _class;
        public ClassInfo(string classText)
        {
            _class = classText;
            InitializeComponent();
        }

        private void ClassInfo_Load(object sender, EventArgs e)
        {
            Text = $"{_class} | {Database.ExecuteWithResult(new SqlCommand($"select Руководитель from Классы where N = '{_class}'"))}";
            ClassInfoDgv.DataSource = Database.ExecuteWithTable(new SqlCommand($"select Фамилия, Имя, Отчество, Номер as [Номер дневника] from Классы, Ученики where Класс = N and N = '{_class}'"));
        }
    }
}
