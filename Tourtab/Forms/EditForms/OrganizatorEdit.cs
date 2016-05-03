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

        private TourtabDb tourtab;

        private bool isEdit = false;
        private int index;

        public OrganizatorEdit()
        {
            InitializeComponent();
        }

        public OrganizatorEdit(bool isEdit, int index)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.index = index;
        }

        private void OrganizatorEdit_Load(object sender, EventArgs e)
        {

            tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

            if (isEdit)
            {
                var entity = tourtab.Organizators
                    .Join(tourtab.Human,
                          org => org.Human_id,
                          hum => hum.Id,
                          (org, hum) => new
                          {
                              id = org.Id,
                              name = hum.Name,
                              surname = hum.Surname,
                              age = hum.Age,
                              address = hum.Address,
                              login = org.Login,
                              password = org.Password,
                              is_admin = org.Is_admin
                          })
                    .Where(x => x.id == this.index)
                    .Select(x => x).First();

                nameInputBox.Text     = entity.name;
                surnameInputBox.Text  = entity.surname;
                addressInputBox.Text  = entity.address;
                ageInputBox.Text      = entity.age.ToString();
                loginInputBox.Text    = entity.login;
                passwordInputBox.Text = entity.password;
                isAdminBox.Checked    = (bool)entity.is_admin;
            }
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
            if(!isEdit)
            {
                pushData();
            }
            else
            {
                updateData();
            }
        }

        private void updateData()
        {
            try
            {
                string name = nameInputBox.Text;
                string surname = surnameInputBox.Text;
                string address = addressInputBox.Text;
                string login = loginInputBox.Text;
                string password = passwordInputBox.Text;
                int age = (int)ageInputBox.Value;

                if ("".Equals(name) || "".Equals(surname) || "".Equals(address) || "".Equals(login) || "".Equals(password))
                {
                    MessageBox.Show("Поля не могут быть пустыми",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                Organizators org = tourtab.Organizators.Where(x => x.Id == this.index).Select(x => x).First();
                Human human = tourtab.Human.Where(x => x.Id == org.Human_id).Select(x => x).First();

                human.Name = name;
                human.Surname = surname;
                human.Address = address;
                human.Age = age;

                org.Login = login;
                org.Password = password;
                org.Is_admin = isAdminBox.Checked;

                tourtab.SubmitChanges();

                MessageBox.Show("Данные успешно обновлены",
                    "Сообщение",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            catch (Exception exc)
            {
                logger.Error(exc.Message);
                MessageBox.Show("Произошел сбой",
                    "Ошибка",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
                return;
            }
        }

        private void pushData()
        {
            try
            {
                string name = nameInputBox.Text;
                string surname = surnameInputBox.Text;
                string address = addressInputBox.Text;
                string login = loginInputBox.Text;
                string password = passwordInputBox.Text;
                int age = (int)ageInputBox.Value;

                if ("".Equals(name) || "".Equals(surname) || "".Equals(address) || "".Equals(login) || "".Equals(password))
                {
                    MessageBox.Show("Поля не могут быть пустыми",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                Human human = new Human
                {
                    Name = name,
                    Surname = surname,
                    Address = address,
                    Age = age
                };

                /*Кладем в базу даных нового человека*/
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
            catch (Exception exc)
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
