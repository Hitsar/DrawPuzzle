using Script.UI;
using UnityEngine;

namespace Script
{
    public class ItemCollision : MonoBehaviour
    {
        [SerializeField] private FinishChecker _finish;
        private Collector _collector;
        private ItemMovement _itemMovement;
        private LozeMenuAnimator _lozeMenuAnimator;

        private void Start()
        {
            _collector = FindObjectOfType<Collector>();
            _itemMovement = GetComponent<ItemMovement>();
            _lozeMenuAnimator = FindObjectOfType<LozeMenuAnimator>(true);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out FinishChecker finish))
            {
                if (finish == _finish)
                    _collector.AddFinisher();
            }
            else
            {
                _itemMovement.Stop();
                _lozeMenuAnimator.gameObject.SetActive(true);
            }
        }
    }
}