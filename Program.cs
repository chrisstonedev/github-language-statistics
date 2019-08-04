using System;
using System.Windows.Forms;

namespace GitHubLanguageStatistics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IModel model = new Model();
            IView view = new View();

            new Presenter(model, view);

            Application.Run(view as Form);
        }
    }
}
