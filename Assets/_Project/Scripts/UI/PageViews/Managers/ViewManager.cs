using System;
using System.Collections.Generic;
using _Project.UI.PageViews.Views;
using UnityEngine;

namespace _Project.UI.PageViews.Managers
{
    public abstract class ViewManager<T> : MonoBehaviour where T : View
    {
        [SerializeField] private T[] _views;

        private View _currentView;

        private readonly Dictionary<Type, T> _viewsDictionary = new();
        private readonly Stack<T> _history = new();

        protected void Awake()
        {
            foreach (var view in _views)
            {
                _viewsDictionary.Add(view.GetType(), view);
                view.Hide();
            }
        }

        protected bool TryGetView<TView>(out View view) where TView : View
        {
            view = null;

            if (_viewsDictionary.TryGetValue(typeof(TView), out var views))
                view = views;

            return view is not null;
        }

        protected void Show(T view, object data = null)
        {
            if (_currentView != null)
                _currentView.Hide();

            view.Show(data);
            _history.Push(view);
            _currentView = view;
        }

        protected void ShowLast()
        {
            if (_history.Count <= 0)
                return;

            var view = _history.Pop();
            view.Hide();

            if (_history.Count <= 0)
                return;

            _currentView = _history.Peek();
            _currentView.Show();
        }
    }
}