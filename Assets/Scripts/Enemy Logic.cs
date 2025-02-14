using JetBrains.Annotations;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] float speed = -1.0f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.GetComponent<Player>() != null)
        {

            Debug.Log("ENEMY TOUCHED OLALA");
            
        }
        
    }
}
