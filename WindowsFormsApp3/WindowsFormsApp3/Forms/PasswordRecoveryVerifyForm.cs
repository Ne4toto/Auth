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

namespace WindowsFormsApp3.Forms
{
    public partial class PasswordRecoveryVerifyForm : Form
    {
        DataBase db = new DataBase();
        public PasswordRecoveryVerifyForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var oldLogin = textBoxOldLogin.Text;
            var mail = textBoxMail.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT Логин, Почта FROM Клиент WHERE Логин = '{oldLogin}' AND Почта ='{mail}';";
                SqlCommand command = new SqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dt.Rows.Count == 0)
            {
                try
                {
                    string query = $"SELECT Логин, Почта FROM Сотрудники WHERE Логин = '{oldLogin}' AND Почта ='{mail}';";
                    SqlCommand command = new SqlCommand(query, db.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("На вашу почту отправлено письмо для восстановления пароля");
            }
        }

        private void labelOldLogin_Click(object sender, EventArgs e)
        {

        }

        private void labelInfoForRecovery_Click(object sender, EventArgs e)
        {

        }
    }
}
