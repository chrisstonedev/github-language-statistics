namespace GitHubLanguageStatistics
{
    public interface IModel
    {
        void AddColors(SortableBindingList<Language> dataSourceByProject, SortableBindingList<Language> dataSourceByLinesOfCode);
        void UpdateList(SortableBindingList<Language> dataSourceByProject, SortableBindingList<Language> dataSourceByLinesOfCode, string userName);
    }
}
