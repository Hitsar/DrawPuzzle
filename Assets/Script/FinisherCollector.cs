using Script.UI;
using UnityEngine;

namespace Script
{
    public class FinisherCollector : MonoBehaviour
    {
        [SerializeField] private int _allItems;
        private FinishMenuAnimator _finishMenuAnimator; 
        private int _finishedItem;

        private void Start() => _finishMenuAnimator = FindObjectOfType<FinishMenuAnimator>(true);
        
        public void AddFinisher()
        {
            _finishedItem++;
            
            if (_finishedItem == _allItems)
                _finishMenuAnimator.gameObject.SetActive(true);
        }
    }
}