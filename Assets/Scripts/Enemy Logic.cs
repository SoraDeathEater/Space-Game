using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] float speed = -1.0f;


    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Projectile>() != null)
        {
            Destroy(gameObject);
        }
    }
}
