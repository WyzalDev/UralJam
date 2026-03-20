using UnityEngine;

namespace _Project.UI.PageViews.Views
{
    public abstract class View : MonoBehaviour
    {
        public virtual void Show(object data = null)
        {
            gameObject.SetActive(true);
        }

        public virtual void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}