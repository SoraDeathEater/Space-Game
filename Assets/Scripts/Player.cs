using UnityEngine;

public class Player : MonoBehaviour
{
    // Collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("PLAYER TOUCHED OLALA");
    }

}
