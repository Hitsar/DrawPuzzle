using UnityEngine;

namespace Script.Item
{
    public class ItemCollision : MonoBehaviour
    {
        [SerializeField] private RouteObserver _finish;
        private PathCollectorData _pathCollectorData;
        private ItemMovement _itemMovement;
        private MenuActivator _menuActivator;

        private void Start()
        {
            _pathCollectorData = FindObjectOfType<PathCollectorData>();
            _itemMovement = GetComponent<ItemMovement>();
            _menuActivator = FindObjectOfType<MenuActivator>();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out RouteObserver finish) && finish == _finish)
                _pathCollectorData.AddFinisher();
            else
            {
                _itemMovement.Stop();
                _menuActivator.LozeMenu();
            }
        }
    }
}