using UnityEngine;

public class moeda : MonoBehaviour
{
    private GameManeger gm;
    public void Start()
    {
        gm = FindFirstObjectByType<GameManeger>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gm.Addcoin(1);
            Destroy(gameObject);
        }
    }
}
