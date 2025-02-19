using UnityEngine;

public class Player : MonoBehaviour
{
    // Projectile Initialization
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] float speed = 1.0f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnProjectile();
        }

        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(horizontalInput * Vector2.right * Time.deltaTime * speed);
    }

    void SpawnProjectile()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
