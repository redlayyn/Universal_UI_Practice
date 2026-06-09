using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuPanel;

    public void TogglePause(bool isPaused)
    {
        pauseMenuPanel.SetActive(isPaused);

        Time.timeScale = isPaused ? 0f : 1f;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
