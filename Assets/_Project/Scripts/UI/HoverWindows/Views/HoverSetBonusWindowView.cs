using TMPro;
using UnityEngine;

namespace _Project.UI.HoverWindows.Views
{
    public class HoverSetBonusWindowView : HoverWindowView
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _type;
        [SerializeField] private TMP_Text _creatureType;
        [SerializeField] private TMP_Text _description;
        
        public override void Show(HoverWindowData data)
        {
            if (data is HoverSetBonusWindowData hoverWindowData)
            {
                _creatureType.text = hoverWindowData.CreatureType;
                _description.text = hoverWindowData.Description;
            }

            gameObject.SetActive(true);
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
        }
    }

    public class HoverSetBonusWindowData : HoverWindowData
    {
        public string CreatureType;
        public string Description;
    }
}