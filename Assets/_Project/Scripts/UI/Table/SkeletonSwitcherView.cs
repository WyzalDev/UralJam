using UnityEngine;
using UnityEngine.UI;

namespace _Project.UI.Table
{
    public class SkeletonSwitcherView : MonoBehaviour
    {
        [SerializeField] private Button _nextSkeletonButton;
        [SerializeField] private Button _prevSkeletonButton;

        public Button NextSkeletonButton => _nextSkeletonButton;
        public Button PrevSkeletonButton => _prevSkeletonButton;
    }
}