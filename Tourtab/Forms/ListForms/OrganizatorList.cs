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

namespace Tourtab.Forms.ListForms
{
    public partial class OrganizatorList : Form
    {

        private TourtabDb tourtab;
        private Logger logger = LogManager.GetLogger("OrganizatorList");

        private bool permission;

        public OrganizatorList()
        {
            InitializeComponent();
        }

        public OrganizatorList(bool permission)
        {
            InitializeComponent();
            this.permission = permission;
        }

        /*Действие при загрузке формы*/
        private void OrganizatorList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        /*Функция загрузки таблицы*/
        private void loadData()
        {
            try
            {
                tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

                /*Делаем объединяющий запрос*/
                organzitorTable.DataSource = tourtab.Organizators
                    .Join(tourtab.Human,
                        org => org.Human_id,
                        hum => hum.Id,
                        (org, hum) => new
                        {
                            id = org.Id,
                            login = org.Login,
                            password = org.Password,
                            name = hum.Name,
                            surname = hum.Surname,
                            age = hum.Age,
                            address = hum.Address,
                            is_admin = org.Is_admin,
                        });

                organzitorTable.RowHeadersVisible = false;
                organzitorTable.Columns["id"].HeaderText = "ID";

                /*В зависиморсти от прав доступа убираем или добавляем некоторые стобцы*/
                if (!permission)
                {
                    organzitorTable.Columns["login"].HeaderText = "Логин";
                    organzitorTable.Columns["login"].Visible = false;
                    organzitorTable.Columns["password"].HeaderText = "Пароль";
                    organzitorTable.Columns["password"].Visible = false;

                    this.addButton.Enabled = false;
                    this.editButton.Enabled = false;
                    this.deleteButton.Enabled = false;
                }

                organzitorTable.Columns["is_admin"].HeaderText = "Права админинстратора";
                organzitorTable.Columns["name"].HeaderText = "Имя";
                organzitorTable.Columns["surname"].HeaderText = "Фамилия";
                organzitorTable.Columns["age"].HeaderText = "Возраст";
                organzitorTable.Columns["address"].HeaderText = "Адрес";


            }
            catch (Exception exc)
            {
                logger.Error(exc.Message);
            }
        }

        /*Действие при нажатии нопки "Добавить"*/
        private void addButton_Click(object sender, EventArgs e)
        {
            Forms.EditForms.OrganizatorEdit orgEdit = new EditForms.OrganizatorEdit();
            var result = orgEdit.ShowDialog();

            if(result == DialogResult.OK)
            {
                loadData();
            }
        }

        /*Действие при нажатии нопки "Изменить"*/
        private void editButton_Click(object sender, EventArgs e)
        {
            int index = int.Parse(organzitorTable.SelectedRows[0].Cells["id"].Value.ToString());
            Forms.EditForms.OrganizatorEdit orgEdit = new EditForms.OrganizatorEdit(true, index);

            var result = orgEdit.ShowDialog();

            if (result == DialogResult.OK)
            {
                loadData();
            }
        }

        /*Действие при нажатии нопки "Удалить"*/
        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить данную запись?",
                "Предупреждение",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string selectedID = organzitorTable.SelectedRows[0].Cells["id"].Value.ToString();

                    int humanID = (int)tourtab.Organizators.Where(x => x.Id == int.Parse(selectedID)).Select(x => x).First().Human_id;

                    Human human = tourtab.Human.Where(x => x.Id == humanID).Select(x => x).First();
                    Organizators org = tourtab.Organizators.Where(x => x.Id == int.Parse(selectedID)).Select(x => x).First();

                    tourtab.Human.DeleteOnSubmit(human);
                    tourtab.Organizators.DeleteOnSubmit(org);

                    tourtab.SubmitChanges();
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Произошла ошибка при попытке удаления",
                        "Ошибка",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                    return;
                }

                loadData();
            }
            else
            {
                return;
            }
        }

        /*Действие при нажатии нопки "Поиск"*/
        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
