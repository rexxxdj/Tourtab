using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace Tourtab.Forms.EditForms
{
    public partial class OrganizatorEdit : Form
    {
        private Logger logger = LogManager.GetLogger("OrganizatorEdit");

        public OrganizatorEdit()
        {
            InitializeComponent();
        }

        /*Генерация случайных логина и пароля*/
        private void generateButton_Click(object sender, EventArgs e)
        {
            byte[] time  = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key   = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());

            loginInputBox.Text    = token.Substring(0, 10);
            passwordInputBox.Text = token.Substring(22, 10);
        }

        /*Кнопка завершения редактирования*/
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name     = nameInputBox.Text;
                string surname  = surnameInputBox.Text;
                string address  = addressInputBox.Text;
                string login    = loginInputBox.Text;
                string password = passwordInputBox.Text;
                int age         = (int)ageInputBox.Value;

                if("".Equals(name) || "".Equals(surname) || "".Equals(address) || "".Equals(login) || "".Equals(password))
                {
                    MessageBox.Show("Поля не могут быть пустыми",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                Human human = new Human
                {
                    Name    = name,
                    Surname = surname,
                    Address = address,
                    Age     = age
                };

                /*Кладем в базу даных нового человека*/
                TourtabDb tourtab = new TourtabDb(Classes.StaticMembers.connectionString);
                tourtab.Human.InsertOnSubmit(human);
                tourtab.SubmitChanges();

                int humanID = (int)tourtab.Human
                    .OrderByDescending(x => x.Id)
                    .Select(x => x).First().Id;

                Organizators org = new Organizators
                {
                    Login = login,
                    Password = password,
                    Human_id = humanID,
                    Is_admin = isAdminBox.Checked
                };

                tourtab.Organizators.InsertOnSubmit(org);
                tourtab.SubmitChanges();

                MessageBox.Show("Данные успешно добавлены",
                    "Сообщение",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch(Exception exc)
            {
                logger.Error(exc.Message);
                MessageBox.Show("Произошел сбой",
                    "Ошибка",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
                return;
            }
        }

        /*Кнопка отмены*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
