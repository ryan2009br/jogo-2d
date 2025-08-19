using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocidade = 2f;
    public float alcance = 3f;

    private float pontoinicialx;
    private int direcao = 1;
    private Rigidbody2D rb;

    public void Start()
    {
        pontoinicialx = transform.position.x;
        rb= GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        rb.linearVelocity = new Vector2(velocidade * direcao, rb.linearVelocity.y);

        if (transform.position.x > pontoinicialx + alcance)
            direcao = -1;
        else if (transform.position.x < pontoinicialx - alcance)
            direcao = 1;


            Vector3 scale = transform.localScale;
        scale.x = Mathf.Abs(scale.x) * direcao;
        transform.localScale = scale;
    }
}
