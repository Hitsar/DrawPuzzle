using UnityEngine;
using UnityEngine.SceneManagement;

namespace Script.UI
{
    public class ButtonManager : MonoBehaviour
    {
        public void NextButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        public void RestartButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void ExitButton()
        {
            SceneManager.LoadScene(0);
        }
    }
}