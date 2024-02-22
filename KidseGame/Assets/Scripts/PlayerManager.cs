using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static int playerHP;
    public static bool isGameOver;
    public TextMeshProUGUI playerHPText;

    void Start()
    {
        isGameOver = false;
        playerHP = 100;
    }

    void Update()
    {
        playerHPText.text = "" + playerHP;
        if (isGameOver)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public IEnumerator Damage(int damageAmount)
    {
        playerHP -= damageAmount;
        if (playerHP <= 0)
        {
            isGameOver = true;
            // Можете добавить дополнительные действия, если нужно
        }
        yield return null;
    }
}
