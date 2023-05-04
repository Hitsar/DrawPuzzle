using DG.Tweening;
using UnityEngine;

namespace Script
{
    public class MovingWall : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float x, y;

        private void Start() => transform.DOMove(new Vector2(x, y), _speed).SetEase(Ease.InOutCubic).SetLoops(-1, LoopType.Yoyo);
    }
}