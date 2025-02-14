using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;

    // Called once per Frame 
    void Update()
    {
        // Keyboard input and movement
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * Vector2.right * Time.deltaTime * speed);


    }
   
    

}
