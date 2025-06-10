using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class LibraristsInfo : Form
    {
        public LibraristsInfo()
        {
            InitializeComponent();
        }

        private void LibraristsInfo_Load(object sender, EventArgs e)
        {
            LibraristsDgv.DataSource = Database.ExecuteWithTable(new SqlCommand("select Фамилия, Имя, Отчество, Телефон from Библиотекари"));
        }
    }
}
