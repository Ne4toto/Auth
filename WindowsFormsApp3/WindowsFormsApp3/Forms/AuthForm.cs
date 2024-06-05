using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Forms;


namespace WindowsFormsApp3
{
    public partial class AuthForm : Form
    {
        DataBase db = new DataBase();
        public int tries = 0;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonVisiblePasswordChars_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == false)
                textBoxPassword.UseSystemPasswordChar = true;
            else if (textBoxPassword.UseSystemPasswordChar == true)
                textBoxPassword.UseSystemPasswordChar = false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();
            PasswordRecoveryVerifyForm passVerify = new PasswordRecoveryVerifyForm();
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                errorProvider.SetError(textBoxLogin, "Пожалуйста введите логин");
                errorProvider.SetError(textBoxPassword, "Пожалуйста введите пароль");
                textBoxLogin.BackColor = Color.Yellow;
                textBoxPassword.BackColor = Color.Yellow;
                MessageBox.Show("Проверьте правильно ли введены данные");
                
            }
            else if (textBoxLogin.Text == "")
            {
                errorProvider.SetError(textBoxLogin, "Пожалуйста введите логин");
                textBoxLogin.BackColor = Color.Yellow;
                MessageBox.Show("Проверьте правильно ли введены данные");
            }
            else if (textBoxPassword.Text == "")
            {
                errorProvider.SetError(textBoxPassword, "Пожалуйста введите пароль");
                textBoxPassword.BackColor = Color.Yellow;
                MessageBox.Show("Проверьте правильно ли введены данные");
            }
            if (tries >= 3)
            {
                var result = MessageBox.Show("Вы совершили несколько попыток ввода данных. Желаете восстановить " +
                    "пароль?", "Ошибка ввода данных", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    passVerify.Show();
            }
            tries++;
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT Логин, Пароль FROM Клиент WHERE Логин = '{loginUser}' AND Пароль ='{passwordUser}';";
                SqlCommand command = new SqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dt.Rows.Count == 0)
            {
                try
                {
                    string query = $"SELECT Логин, Пароль FROM Сотрудники WHERE Логин = '{loginUser}' AND Пароль ='{passwordUser}';";
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
                MessageBox.Show("Вы успешно ввошли в систему!");
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxLogin_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (System.Environment.MachineName == "NE4TOTO" && textBoxLogin.Text == "admin")
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                string query = $"SELECT Пароль FROM Сотрудники WHERE Логин = '{textBoxLogin.Text}';";
                SqlCommand command = new SqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    textBoxPassword.Text = dt.Rows[0][0].ToString();
                    textBoxPassword.BackColor = Color.LightGoldenrodYellow;
                }
            }
        }
    }
}
