using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourtab
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*Авторизация*/
            var auth = new AuthForm().ShowDialog();

            Forms.MainContainer mainContainer;

            /*В случае, если результат диалога будет ОК, запустить главное окно приложения*/
            if (auth == DialogResult.OK)
            {
                /*Выдаются права доступа администратора*/
                mainContainer = new Forms.MainContainer(true);
            }
            else if(auth == DialogResult.Yes)
            {
                /*Выдаются права доступа организатор*/
                mainContainer = new Forms.MainContainer(false);
            }
            else
            {
                return;
            }
            Application.Run(mainContainer);
        }
    }
}
