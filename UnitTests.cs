using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GitHubLanguageStatistics
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test()
        {
            Mock<IModel> model = new Mock<IModel>();
            model.Setup(m => m.UpdateList(It.IsAny<SortableBindingList<Language>>(), It.IsAny<SortableBindingList<Language>>(), It.IsAny<string>()))
                .Callback<SortableBindingList<Language>, SortableBindingList<Language>, string> ((x, y, _) =>
                {
                    x.Add(new Language { LanguageName = "Item 4", Count = 2 });
                    y.Add(new Language { LanguageName = "Item 4", Count = 7 });
                    x.Add(new Language { LanguageName = "Item 2", Count = 2 });
                    y.Add(new Language { LanguageName = "Item 2", Count = 6 });
                    x.Add(new Language { LanguageName = "Item 1", Count = 1 });
                    y.Add(new Language { LanguageName = "Item 1", Count = 5 });
                    x.Add(new Language { LanguageName = "Item 5", Count = 3 });
                    y.Add(new Language { LanguageName = "Item 5", Count = 5 });
                    x.Add(new Language { LanguageName = "Item 3", Count = 1 });
                    y.Add(new Language { LanguageName = "Item 3", Count = 3 });
                });
            Mock<IView> view = new Mock<IView>();
            Presenter presenter = new Presenter(model.Object, view.Object);

            presenter.Refresh();
        }
    }
}
