using UnityEngine;

public class plataforma : MonoBehaviour
{
    public float movespeed = 2f;
    public bool platform1, platform2;
    public bool moveright = true, moveup = true;

    private void Update()
    {
        if (platform1)
        {
            if(transform.position.x > -5)
            {
                moveright = false;
            }
            else if (transform.position.x < -8)
            {
                moveright = true;
            }

            if (moveright)
            {
                transform.Translate(Vector2.right * movespeed * Time.deltaTime);
            }
            else 
            {
                transform.Translate(Vector2.right * -movespeed * Time.deltaTime);
            }
        }
        if (platform2)
        {
            if (transform.position.y > 6)
            {
                moveup = false;
            }
            else if (transform.position.y < 1)
            {
                moveup = true;
            }

            if (moveup)
            {
                transform.Translate(Vector2.up * movespeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.up * -movespeed * Time.deltaTime);
            }
        }

    }
}

