using _Project.UI.PageViews.Views;

namespace _Project.UI.PageViews.Managers
{
    public class PopupManager : ViewManager<Popup>
    {
        public void Show<TPopup>(object data = null) where TPopup : Popup, new()
        {
            if (!TryGetView<TPopup>(out var view))
                return;

            Show(view as TPopup, data);
        }

        public void Last()
        {
            ShowLast();
        }
    }
}