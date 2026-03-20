using TMPro;
using UnityEngine;

namespace _Project.UI.HoverWindows.Views
{
    public class HoverAbilityWindowView : HoverWindowView
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _cooldown;
        [SerializeField] private TMP_Text _targetType;
        [SerializeField] private TMP_Text _description;
        
        public override void Show(HoverWindowData data)
        {
            if (data is HoverAbilityWindowData hoverWindowData)
            {
                _name.text = hoverWindowData.Name;
                _cooldown.text = hoverWindowData.Cooldown;
                _targetType.text = hoverWindowData.TargetType;
                _description.text = hoverWindowData.Description;
            }

            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
    }

    public class HoverAbilityWindowData : HoverWindowData
    {
        public string Name;
        public string Cooldown;
        public string TargetType;
        public string Description;
    }
}