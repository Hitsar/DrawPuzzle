using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{
    public class MainMenuAnimator : MonoBehaviour
    {
        [SerializeField] private Image _startButton;

        private void Start()
        {
            _startButton.transform.DOLocalMoveY(0, 1).SetEase(Ease.OutCubic).OnComplete(() =>
            {
                _startButton.transform.DOScale(new Vector2(1.04f, 1.04f), 0.6f).SetEase(Ease.InOutCubic)
                    .SetLoops(-1, LoopType.Yoyo);
            });
        }
    }
}