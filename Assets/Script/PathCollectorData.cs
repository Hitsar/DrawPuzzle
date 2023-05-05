using System;
using UnityEngine;

namespace Script
{
    public class PathCollectorData : MonoBehaviour
    {
        [SerializeField] private int _countItems = 2;
        
        private MenuActivator _menuActivator;
        private int _finishedItem;
        private int _route;

        public event Action MoveItem;
        
        private void Start() => _menuActivator = FindObjectOfType<MenuActivator>();

        public void AddFinisher()
        {
            _finishedItem++;
            if (_finishedItem == _countItems)
                _menuActivator.FinishMenu();
        }

        public void AddRoute()
        {
            _route++;
            if (_route == _countItems)
                MoveItem?.Invoke();
        }

        public void RouteOverwritten() => _route--;
    }
}