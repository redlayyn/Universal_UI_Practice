using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // функция для запуска
    public void PlayGame()
    {
        // загружает следующую сцену по индексу (1 - это будет наша игровая сцена)
        SceneManager.LoadScene(1);
    }

    // функция для выхода
    public void ExitGame()
    {
        Debug.Log("Игрок нажал ВЫХОД");
        Application.Quit(); // закрывает игру
    }
}
