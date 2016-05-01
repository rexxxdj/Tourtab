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
        private TourtabDb tourtab;
        private List<Match> matchList;
        private int tournamentID;

        public TournamentEdit()
        {
            InitializeComponent();
        }

        /*Действие при загрузке формы*/
        private void TournamentEdit_Load(object sender, EventArgs e)
        {
            matchList = new List<Match>();
            tournamentMatchesTable.DataSource = matchList;

            for(int i = 0; i < tournamentMatchesTable.Columns.Count; i++)
            {
                tournamentMatchesTable.Columns[i].Visible = false;
            }

            tournamentMatchesTable.Columns["id"].HeaderText = "ID";
            tournamentMatchesTable.Columns["id"].Visible = true;
            tournamentMatchesTable.Columns["Location_id"].HeaderText = "Место и время проведения";
            tournamentMatchesTable.Columns["Location_id"].Visible = true;
            tournamentMatchesTable.Columns["Sport_id"].HeaderText = "Вид спорта";
            tournamentMatchesTable.Columns["Sport_id"].Visible = true;

            tourtab = new TourtabDb(Classes.StaticMembers.connectionString);

            /*Получаем индекс последнего элемента турниров*/
            var lastEntity = tourtab.Tournament.OrderByDescending(x => x.Id).Select(x => x).FirstOrDefault();
            if(lastEntity != null)
            {
                logger.Info("Entity isn't null");
                tournamentID = (int)lastEntity.Id + 1;
            }
            else
            {
                logger.Info("Entity is null");
                tournamentID = 1;
            }
        }

        /*Кнопка завершения редактирования*/
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*Поле инициализаций*/
                string tournamentName   = tournamentNameInputBox.Text;          // Название турнира
                string tournamentPlace  = tournamentPlaceInputBox.Text;         // Место проведения турнира
                DateTime tournamentDate = tournamentDatePicker.Value.Date;      // Дата проведения турнира
                TimeSpan tournamentTime = tournamentTimePicker.Value.TimeOfDay; // Время проведения турнира

                /*Проверка на заполненность полей*/
                if ("".Equals(tournamentName) || "".Equals(tournamentPlace))
                {
                    MessageBox.Show("Поля не могут быть пустыми",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                /*Приводим дату в вид ДД:ММ:ГГ ЧЧ:ММ:СС*/
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

                /*Проверяем количество матчей*/
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
            MatchEdit mEdit = new MatchEdit();
            if (mEdit.ShowDialog() == DialogResult.OK)
            {
                Match m = mEdit.NewMatch;
                m.Tournament_id = tournamentID;
                matchList.Add(mEdit.NewMatch);
            }
            else
            {
                return;
            }
        }

        /*Кнопка исключения матча*/
        private void tournamentMatchesDeleteButton_Click(object sender, EventArgs e)
        {

        }

        /*Кнопка отмены*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}
