using System;
using TMPro;
using UnityEngine;

namespace _Project.UI.HoverWindows.Managers
{
    public class HoverStatWindowView : HoverWindowView
    {
        [SerializeField] private TMP_Text _description;

        public override void Show(HoverWindowData data)
        {
            if (data is HoverStatWindowData hoverWindowData)
            {
                _description.text = hoverWindowData.Description;
            }

            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
    }

    [Serializable]
    public class HoverStatWindowData : HoverWindowData
    {
        public string Description;
    }
}