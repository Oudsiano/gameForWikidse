using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void RestartGame()
    {
        // Загрузить сцену с основным игровым процессом (поменяйте "GameScene" на ваше название сцены)
        SceneManager.LoadScene("2Version");
    }
}
