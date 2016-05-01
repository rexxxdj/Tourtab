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

namespace Tourtab.Forms
{
    public partial class MainContainer : Form
    {
        private Logger logger = LogManager.GetLogger("MainContainer");

        /*Переменная прав доступа*/
        private bool permission;

        public MainContainer()
        {
            InitializeComponent();
            this.FormClosing += this.MainContainer_FormClosing;
        }

        public MainContainer(bool permission)
        {
            InitializeComponent();
            this.permission = permission;
            this.FormClosing += this.MainContainer_FormClosing;
        }

        /*Действия при загрузке основного контейнера*/
        private void MainContainer_Load(object sender, EventArgs e)
        {

            if (permission)
            {
                logger.Info("Вы зашли как администратор");
            }
            else
            {
                logger.Info("Вы зашли как организатор");
            }

            Forms.ListForms.TournamentList tournamentList = new ListForms.TournamentList();
            tournamentList.MdiParent = this;
            tournamentList.Show();

        }

        /*Отлавливаем действие при выходе*/
        private void MainContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Диалоговое окно закрытия программы*/
            var result = MessageBox.Show("Вы действительно хотите закрыть программу?", 
                                         "Предупреждение", 
                                         buttons: MessageBoxButtons.YesNo, 
                                         icon: MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /*Переопределяем действие после закрытия формы*/
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*Открыть окно списка турниров*/
        private void списокТурнировToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ListForms.TournamentList tournamentList = new ListForms.TournamentList();
            tournamentList.MdiParent = this;
            tournamentList.Show();
        }

        /*Свойство прав доступа*/
        public bool Permission
        {
            get
            {
                return this.permission;
            }
        }
    }
}
