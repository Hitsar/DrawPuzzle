using System;
using Script.UI;
using UnityEngine;

namespace Script
{
    public class Collector : MonoBehaviour
    {
        [SerializeField] private int _countItems;
        
        private FinishMenuAnimator _finishMenuAnimator;
        private int _finishedItem;
        private int _route;

        public event Action MoveItem;
        
        private void Start() => _finishMenuAnimator = FindObjectOfType<FinishMenuAnimator>(true);

        public void AddFinisher()
        {
            _finishedItem++;
            if (_finishedItem == _countItems)
                _finishMenuAnimator.gameObject.SetActive(true);
        }

        public void AddRoute()
        {
            _route++;
            if (_route == _countItems)
                MoveItem?.Invoke();
        }

        public void LineOverwritten() => _route--;
    }
}