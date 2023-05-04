using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Script.UI
{
    public class FinishMenuAnimator : MonoBehaviour
    {
        [SerializeField] private Image _nextButton, _exitButton;
        
        private void OnEnable()
        {
            _nextButton.transform.localPosition = new Vector2(0, 260);
            _exitButton.transform.localPosition = new Vector2(0, -260);
            
            _nextButton.transform.DOLocalMoveY(30, 0.5f).SetEase(Ease.OutElastic);
            _exitButton.transform.DOLocalMoveY(-80, 0.3f).SetDelay(0.4f).SetEase(Ease.OutCubic);
        }
    }
}