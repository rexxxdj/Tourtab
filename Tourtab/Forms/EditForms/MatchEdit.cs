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
    public partial class MatchEdit : Form
    {
        private Logger logger = LogManager.GetLogger("MatchEdit");

        private Match newMatch;

        public MatchEdit()
        {
            InitializeComponent();
        }

        /*Кнопка завершения редактирования матча*/
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*Поле инициализаций*/
                int roundCount     = (int)matchRoundBox.Value;
                int sportID        = matchSportBox.SelectedIndex;
                string matchPlace  = matchPlaceBox.Text;
                DateTime matchDate = matchDatePickerBox.Value.Date;
                TimeSpan matchTime = matchTimePickerBox.Value.TimeOfDay;

                /*Приводим дату в вид ДД:ММ:ГГ ЧЧ:ММ:СС*/
                matchDate = matchDate.Add(matchTime);

                /*Поле проверок*/
                if ("".Equals(matchPlace) || sportID == -1)
                {
                    MessageBox.Show("Поля не могут быть пустыми",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                if (roundCount == 0)
                {
                    MessageBox.Show("Число раундов должно быть больше 0",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                TourtabDb tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

                var entity = tourtab.Location
                    .Where(x => x.Place.ToLower() == matchPlace.ToLower() && x.Date == matchDate)
                    .Select(x => x);

                int locationIndex;

                /*Если нет в базе добавляем*/
                if (entity.Count() == 0)
                {
                    Location location = new Tourtab.Location
                    {
                        Date = matchDate,
                        Place = matchPlace
                    };

                    tourtab.Location.InsertOnSubmit(location);
                    tourtab.SubmitChanges();

                    logger.Info("Добавление прошло успешно");

                    /*Получаем индекс локации*/
                    locationIndex = (int)tourtab.Location
                        .Where(x => x.Place.ToLower() == matchPlace.ToLower() && x.Date == matchDate)
                        .Select(x => x.Id).First();
                }
                else
                {
                    locationIndex = (int)entity.First().Id;
                }

                /*Создаем новый экземпляр матча*/
                this.newMatch = new Match
                {
                    Round_count = roundCount,
                    Location_id = locationIndex,
                    Sport_id = sportID
                };

                this.DialogResult = DialogResult.OK;
            }
            catch(Exception exc)
            {
                logger.Error(exc.Message);
            }
        }

        /*Кнопка отмены*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        public Match NewMatch
        {
            get
            {
                return this.newMatch;
            }
        }
    }
}
