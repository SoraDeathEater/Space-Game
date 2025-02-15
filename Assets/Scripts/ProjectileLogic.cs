using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    // Projectile Initialization

    [SerializeField] GameObject projectilePrefab;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnProjectile();
        }
    }

    // Projectile Shooter
    void SpawnProjectile()
    {

        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
