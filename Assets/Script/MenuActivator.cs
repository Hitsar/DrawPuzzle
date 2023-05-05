using Script.UI;
using UnityEngine;

namespace Script
{
    public class MenuActivator : MonoBehaviour
    {
        [SerializeField] private MenuAnimator _finishMenu;
        [SerializeField] private MenuAnimator _lozeMenu;

        [SerializeField] private ParticleSystem _finishParticle;
        [SerializeField] private ParticleSystem _lozeParticle;

        public void FinishMenu() => Activator(_finishMenu, _finishParticle);

        public void LozeMenu() => Activator(_lozeMenu, _lozeParticle);

        private void Activator(MenuAnimator menu, ParticleSystem particle)
        {
            particle.Play();
            menu.gameObject.SetActive(true);
        }
    }
}