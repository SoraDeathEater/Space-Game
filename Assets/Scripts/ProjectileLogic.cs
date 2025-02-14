using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    // Projectile Initialization

    [SerializeField] GameObject projectilePrefab;

    void Start()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnProjectile();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Projectile Shooter
    void SpawnProjectile()
    {

        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
