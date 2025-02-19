using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject gameOverMenu;


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyLogic>() != null)
        {
            gameOverMenu.SetActive(true);
        }
    }
}
