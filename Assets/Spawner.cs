using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Contains both Meteor and Projectile Spawns

    
    [SerializeField] GameObject meteorPrefab;
    

    // Meteor Initializations
    [SerializeField] float timeBetweenSpawns; 
    float elapsedSinceSpawn = 0;

   
    void Start()
    {
        
    }

    // Spawn Meteors Timer & Projectile Button

    void Update()
    {
        elapsedSinceSpawn += Time.deltaTime;

        if(elapsedSinceSpawn > timeBetweenSpawns)
        {
            SpawnMeteor();
            elapsedSinceSpawn = 0;
        }

        
    }

    // Meteor Spawns
    void SpawnMeteor()
    {
        int rx = Random.Range(-8, 8);

        Vector3 position = new Vector3(rx, 5, 0);

        Instantiate(meteorPrefab, position, Quaternion.identity);
    }


}
