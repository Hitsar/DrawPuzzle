using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

namespace Script.UI
{
    public class LozeMenuAnimator : MonoBehaviour
    {
        [SerializeField] private Image _restartButton, _exitButton;

        private void OnEnable()
        {
            _restartButton.transform.localPosition = new Vector2(0, 260);
            _exitButton.transform.localPosition = new Vector2(0, -260);
            
            _restartButton.transform.DOLocalMoveY(30, 0.5f).SetEase(Ease.OutCubic);
            _exitButton.transform.DOLocalMoveY(-80, 0.3f).SetDelay(0.4f).SetEase(Ease.OutCubic);
        }
    }
}