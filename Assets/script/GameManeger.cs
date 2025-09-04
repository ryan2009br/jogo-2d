using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManeger : MonoBehaviour
{
    public TMP_Text coinCount;
    public int coin;

    public Transform player;
    private PlayerHealth health;

    public void Start()
    {
        health = FindFirstObjectByType<PlayerHealth>();
    }

    public void Update()
    {
        coinCount.text = coin.ToString();

        if (health.currentHealth <= 0 )
        {
            GameOver();
        }
        if (player.transform.position.y <= -10 )
        {
            GameOver();
        }
    }
    public void Addcoin( int i)
    {
        i = coin;
        coin++;
    }
    public void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
