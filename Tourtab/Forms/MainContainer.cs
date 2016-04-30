using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourtab.Forms
{
    public partial class MainContainer : Form
    {
        public MainContainer()
        {
            InitializeComponent();
        }

        /*Действия при загрузке основного контейнера*/
        private void MainContainer_Load(object sender, EventArgs e)
        {
            Forms.ListForms.TournamentList tournamentList = new ListForms.TournamentList();
            tournamentList.MdiParent = this;
            tournamentList.Show();
        }

        /*Переопределяем действия при выходе из программы*/
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }
    }
}
