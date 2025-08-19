using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform player;

    public void Update()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
