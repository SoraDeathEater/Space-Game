using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector2.up * Time.deltaTime * speed);

        if(transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }

    

}
