using Script.UI;
using UnityEngine;

namespace Script
{
    public class ItemCollision : MonoBehaviour
    {
        private FinisherCollector _finisherCollector;
        private ItemMovement _itemMovement;
        private LozeMenuAnimator _lozeMenuAnimator;

        private void Start()
        {
            _finisherCollector = FindObjectOfType<FinisherCollector>();
            _itemMovement = GetComponent<ItemMovement>();
            _lozeMenuAnimator = FindObjectOfType<LozeMenuAnimator>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out FinishChecker finish))
            {
                print("win");
                _finisherCollector.AddFinisher();
            }
            else
            {
                print("HEY STOP");
                _itemMovement.Stop();
                _lozeMenuAnimator.gameObject.SetActive(true);
            }
        }
    }
}