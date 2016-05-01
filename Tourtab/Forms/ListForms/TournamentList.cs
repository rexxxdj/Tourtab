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
    public partial class TournamentList : Form
    {
        /*Экземляр базы данных*/
        private Tourtab.TourtabDb tourTabDb;
        /*Логгер*/
        private Logger logger = LogManager.GetLogger("AuthForm");

        public TournamentList()
        {
            InitializeComponent();
        }

        /*Действие при загрузке формы*/
        private void TournamentList_Load(object sender, EventArgs e)
        {

            try
            {
                tourTabDb = new TourtabDb(Classes.StaticMembers.connectionString);
                if (tourTabDb != null)
                {
                    logger.Info("Соединение установлено");

                    /*Получаем список турниров*/
                    var table = tourTabDb.Tournament.Join(tourTabDb.Sport,
                                                         tournament => tournament.Sport_id,
                                                         sport => sport.Id,
                                                         (tournament, sport) => new
                                                         {
                                                             id = tournament.Id,
                                                             sport = sport.Name,
                                                             match_count = tournament.Match
                                                         });
                    tournamentTable.DataSource = table;
                    tournamentTable.Columns["id"].HeaderText          = "Индекс";
                    tournamentTable.Columns["sport"].HeaderText       = "Вид спорта";
                    tournamentTable.Columns["match_count"].HeaderText = "Число матчей";
                }
                else
                {
                    logger.Info("Соединение не установлено");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла ошибка\n" + exc.Message);
                logger.Error("Error message: " + exc.Message);
            }
        }

        /*Действие при нажатии нопки "Добавить"*/
        private void addButton_Click(object sender, EventArgs e)
        {
            Forms.EditForms.TournamentEdit tourEdit = new EditForms.TournamentEdit();
            tourEdit.MdiParent = this.MdiParent;
            tourEdit.Show();
        }

        /*Действие при нажатии нопки "Изменить"*/
        private void editButton_Click(object sender, EventArgs e)
        {
            Forms.EditForms.TournamentEdit tourEdit = new EditForms.TournamentEdit();
            tourEdit.MdiParent = this.MdiParent;
            tourEdit.Show();
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
