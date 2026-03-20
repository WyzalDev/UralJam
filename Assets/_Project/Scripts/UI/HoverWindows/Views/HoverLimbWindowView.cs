using TMPro;
using UnityEngine;

namespace _Project.UI.HoverWindows.Views
{
    public class HoverLimbWindowView : HoverWindowView
    {
        [SerializeField] private TMP_Text _name;
        [SerializeField] private TMP_Text _type;
        [SerializeField] private TMP_Text _creatureType;
        [SerializeField] private TMP_Text _description;
        
        public override void Show(HoverWindowData data)
        {
            if (data is HoverLimbWindowData hoverWindowData)
            {
                _name.text = hoverWindowData.Name;
                _type.text = hoverWindowData.Type;
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

    public class HoverLimbWindowData : HoverWindowData
    {
        public string Name;
        public string Type;
        public string CreatureType;
        public string Description;
    }
}