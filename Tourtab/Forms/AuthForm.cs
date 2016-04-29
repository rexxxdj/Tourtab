using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Tourtab
{
    public partial class AuthForm : Form
    {
        /*Строка подключения*/
        
        /*Экземляр базы данных*/
        private Tourtab.TourtabDb tourTabDb;
        /*Логгер*/
        private Logger logger = LogManager.GetLogger("AuthForm");

        public AuthForm()
        {
            InitializeComponent();
        }

        /*Действие при загрузке формы*/
        private void AuthForm_Load(object sender, EventArgs e)
        {
            try
            {
                tourTabDb = new TourtabDb(Classes.StaticMembers.connectionString);
                if(tourTabDb != null)
                {
                    logger.Info("Соединение установлено");                  
                }
                else
                {
                    logger.Info("Соединение не установлено");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Произошла ошибка\n" + exc.Message);
                logger.Error("Error message: " + exc.Message);
            }
        }

        /*Кнопка "Войти"*/
        private void authFinishBtn_Click(object sender, EventArgs e)
        {
            /*Поиск совпадний в базе данных. Если все(логин, пароль) найдено то
            запускаем основную программу, иначе выводим сообщение об ошибке.*/

            string userLogin   = loginInputBox.Text;    // Окно ввода логина
            string userPasword = passwordInputBox.Text; // Окно ввода пароля
            bool isAdmin       = iamAdmin.Checked;      // Админ?

            /*Получаем список организаторов*/
            var orgs = tourTabDb.Organizators
                .Where(x => x.Login == userLogin && x.Password == userPasword && x.Is_admin == isAdmin)
                .Select(x => x);

            /*Проверяем наличие в базе данных*/
            if(orgs.Count() == 0)
            {
                /*Выводим сообщение об ошибке*/
                MessageBox.Show("Не верно введены логин или пароль");
            }
            else
            {
                /*Запускаем основную программу*/
                logger.Info("Вход выполнен");
            }

        }
    }
}
