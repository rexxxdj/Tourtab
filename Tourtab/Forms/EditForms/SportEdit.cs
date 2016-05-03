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
    public partial class SportEdit : Form
    {
        private Logger logger = LogManager.GetLogger("SportEdit");
        private TourtabDb tourtab;

        public SportEdit()
        {
            InitializeComponent();
        }

        /*Действие при загрзке формы*/
        private void SportEdit_Load(object sender, EventArgs e)
        {
            tourtab = new TourtabDb(Classes.StaticMembers.connectionString);
        }

        /*Кнопка завершения редактирования*/
        private void completeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sportType = sportTypeInputBox.Text;

                if ("".Equals(sportType))
                {
                    MessageBox.Show("Поле не может быть пустым",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                if(tourtab.Sport.Where(x => x.Name.ToLower() == sportType.ToLower()).Select(x => x).Count() > 0)
                {
                    MessageBox.Show("Такой вид спорта уже есть базе данных",
                        "Предупреждение",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Warning);
                    return;
                }

                Sport sport = new Sport
                {
                    Name = sportType
                };

                tourtab.Sport.InsertOnSubmit(sport);
                tourtab.SubmitChanges();

            }
            catch(Exception exc)
            {
                logger.Error(exc.Message);
                MessageBox.Show("Произошел сбой",
                    "Сообщение",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
                return;
            }

        }

        /*Кнопка отмены редактирования*/
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
