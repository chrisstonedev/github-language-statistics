using System;
using System.Drawing;
using System.Linq;

namespace GitHubLanguageStatistics
{
    public class Presenter
    {
        private readonly IModel model;
        private readonly IView view;

        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            this.view.Presenter = this;
        }

        internal void Refresh()
        {
            try
            {
                view.DataSourceByProject.Clear();
                view.DataSourceByLinesOfCode.Clear();
                model.UpdateList(view.DataSourceByProject, view.DataSourceByLinesOfCode, view.UserName);
                model.AddColors(view.DataSourceByProject, view.DataSourceByLinesOfCode);
                foreach (Language language in view.DataSourceByProject)
                    language.Percent = ((double)language.Count / view.DataSourceByProject.Sum(x => x.Count)).ToString("P");
                foreach (Language language in view.DataSourceByLinesOfCode)
                    language.Percent = ((double)language.Count / view.DataSourceByLinesOfCode.Sum(x => x.Count)).ToString("P");
                view.Title = "GitHub Language Statistics for " + view.UserName;
                view.TitleColor = Color.Black;
                view.SortGrids();
            }
            catch (Exception ex)
            {
                view.Title = ex.Message;
                view.TitleColor = Color.Red;
            }
        }
    }
}
