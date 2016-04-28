using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourtab
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        /*Кнопка "Войти"*/
        private void authFinishBtn_Click(object sender, EventArgs e)
        {
            /*Поиск совпадний в базе данных. Если все(логин, пароль) найдено то
            запускаем основную программу, иначе выводим сообщение об ошибке.*/

            string userLogin   = loginInputBox.Text;    // Окно ввода логина
            string userPasword = passwordInputBox.Text; // Окно ввода пароля
            bool isAdmin       = iamAdmin.Checked;      // Админ?


        }
    }
}
