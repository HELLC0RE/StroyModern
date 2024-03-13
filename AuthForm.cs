using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StroyModern
{   
    public partial class AuthFrom : Form
    {
        private int loginAttempts = 0;
        public int CountOfAttepts { get; set; } = 0;
        private NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=StroyModern;User Id=postgres;Password=qwerty123");
        public AuthFrom()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = loginText.Text;
            string password = passwordText.Text;
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Укажите пароль и логин");
                return;
            }

            if (!userIsValid(login, password))
            {
                loginAttempts++;
                if (loginAttempts < 3)
                {
                    MessageBox.Show("Данные введены неверно!");
                    return;
                }
                else
                {
                    int remainingTime = 30; 
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000; 
                    timer.Tick += (timerSender, timerArgs) =>
                    {
                        remainingTime--;
                        if (remainingTime > 0)
                        {
                            label4.Text = $"Подождите ещё {remainingTime} секунд...";
                        }
                        else
                        {
                            timer.Stop(); 
                            Hide();
                            CaptchaForm captchaForm = new CaptchaForm();
                            captchaForm.CountOfAttepts = CountOfAttepts;
                            captchaForm.FormClosed += (formSender, formArgs) => Close(); 
                            captchaForm.Show();
                        }
                    };
                    timer.Start(); 
                    return;
                }
            }

            Hide();
            ProductsList productsList = new ProductsList();
            productsList.label1.Text = login;
            productsList.FormClosed += (s, args) => Close(); // Добавлен обработчик события FormClosed
            productsList.Show();
        }

        public bool userIsValid(string login, string password)
        {
            connection.Open();
            var command = new NpgsqlCommand("Select * from users u INNER JOIN roles r ON r.id = u.roles_id" +
                " where login=@login and password=@password", connection);
            command.Parameters.AddWithValue("login", login);
            command.Parameters.AddWithValue("password", password);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                string role = (string)reader["role_name"];
                connection.Close();
                reader.Close();
                if (!role.Equals("Администратор") && !role.Equals("Менеджер"))
                {
                    return false;
                }
                return true;
            }
            else
            {
                connection.Close();
                reader.Close();
                return false;
            }
        }
    }
}
