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
    public partial class TournamentEdit : Form
    {
        private Logger logger = LogManager.GetLogger("TournamentEdit");

        public TournamentEdit()
        {
            InitializeComponent();
        }

        /*Действие при загрузке формы*/
        private void TournamentEdit_Load(object sender, EventArgs e)
        {
        }

        /*Кнопка завершения редактирования*/
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*Получаем бд*/
                TourtabDb tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

                string tournamentName = tournamentNameInputBox.Text;            // Название турнира
                string tournamentPlace = tournamentPlaceInputBox.Text;          // Место проведения турнира
                DateTime tournamentDate = tournamentDatePicker.Value.Date;      // Дата проведения турнира
                TimeSpan tournamentTime = tournamentTimePicker.Value.TimeOfDay; // Время проведения турнира

                tournamentDate = tournamentDate.Add(tournamentTime);
                
                var entity = tourtab.Location
                    .Where(x => x.Place.ToLower() == tournamentPlace.ToLower() && x.Date == tournamentDate)
                    .Select(x => x);

                int locationIndex = 0;

                /*Если нет в базе добавляем*/
                if (entity.Count() == 0)
                {
                    Location location = new Tourtab.Location
                    {
                        Date = tournamentDate,
                        Place = tournamentPlace
                    };

                    tourtab.Location.InsertOnSubmit(location);
                    tourtab.SubmitChanges();

                    logger.Info("Добавление прошло успешно");

                    /*Получаем индекс локации*/
                    locationIndex = (int)tourtab.Location
                        .Where(x => x.Place.ToLower() == tournamentPlace.ToLower() && x.Date == tournamentDate)
                        .Select(x => x.Id).First();
                }
                else
                {
                    locationIndex = (int)entity.First().Id;
                }

                logger.Info("Индекс локации: " + locationIndex);

                int matchCount = tournamentMatchesTable.Rows.Count;

                if(matchCount == 0)
                {
                    MessageBox.Show("Число матчей не может быть нулевым", 
                        "Предупреждение", 
                        buttons: MessageBoxButtons.OK, 
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                Tournament newTournament = new Tournament()
                {
                    Name = tournamentName,
                    Location_id = locationIndex,
                    Match = matchCount
                };
            }
            catch (Exception exc)
            {
                logger.Error(exc.Message);
            }
        }

        /*Кнопка добавления матча*/
        private void tournamentMatchesAddButton_Click(object sender, EventArgs e)
        {

        }

        /*Кнопка отмены*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
