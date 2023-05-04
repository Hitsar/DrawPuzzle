using UnityEngine;

namespace Script.UI
{
    public class Menus : MonoBehaviour
    {
        private static Menus _instanse;

        private void Awake()
        {
            if (_instanse != null)
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
            _instanse = this;
        }
    }
}