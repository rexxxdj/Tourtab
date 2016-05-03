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
    public partial class SportList : Form
    {
        TourtabDb tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

        private Logger logger = LogManager.GetLogger("SportList");
        private bool permission;

        public SportList()
        {
            InitializeComponent();
        }

        public SportList(bool permission)
        {
            InitializeComponent();
            this.permission = permission;
        }

        /*Действие при загрузку формы*/
        private void SportList_Load(object sender, EventArgs e)
        {
            if(!permission)
            {
                this.addButton.Enabled    = false;
                this.editButton.Enabled   = false;
                this.deleteButton.Enabled = false;
            }


            sportTable.DataSource = tourtab.Sport.Select(x => x);
        }

        /*Действие при нажатии нопки "Добавить"*/
        private void addButton_Click(object sender, EventArgs e)
        {
            var result = new Forms.EditForms.SportEdit().ShowDialog();
            if(result == DialogResult.OK)
            {
                sportTable.DataSource = tourtab.Sport.Select(x => x);
            }
        }

        /*Действие при нажатии нопки "Изменить"*/
        private void editButton_Click(object sender, EventArgs e)
        {

        }

        /*Действие при нажатии нопки "Удалить"*/
        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        /*Действие при нажатии нопки "Поиск"*/
        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}
