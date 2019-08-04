using System.Drawing;

namespace GitHubLanguageStatistics
{
    public interface IView
    {
        SortableBindingList<Language> DataSourceByProject { get; }
        SortableBindingList<Language> DataSourceByLinesOfCode { get; }
        Presenter Presenter { set; }
        string Title { set; }
        Color TitleColor { set; }
        string UserName { get; }

        void SortGrids();
    }
}
