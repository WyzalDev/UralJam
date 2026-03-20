using _Project.UI.PageViews.Views;

namespace _Project.UI.PageViews.Managers
{
    public class PageManager : ViewManager<Page>
    {
        public void Show<TPage>(object data = null) where TPage : Page
        {
            if (!TryGetView<TPage>(out var view))
                return;

            Show(view as TPage, data);
        }

        public void Last()
        {
            ShowLast();
        }
    }
}