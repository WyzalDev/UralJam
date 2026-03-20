using System;
using TMPro;
using UnityEngine;

namespace _Project.UI.HoverWindows
{
    public abstract class HoverWindowView : MonoBehaviour
    {
        public abstract void Show(HoverWindowData data);
        public abstract void Hide();
    }

    public abstract class HoverWindowData
    {
    }
    
    
    
    
}