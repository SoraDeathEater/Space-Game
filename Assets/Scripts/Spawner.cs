using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject meteorPrefab;

    [SerializeField] float timeBetweenSpawn;
    float elapsedSinceSpawn = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedSinceSpawn += Time.deltaTime;

        if(elapsedSinceSpawn > timeBetweenSpawn)
        {
            SpawnMeteor();
            elapsedSinceSpawn = 0;
        }
    }

    void SpawnMeteor()
    {
        int rx = Random.Range(-8, 8);

        Vector3 positon = new Vector3(rx, 5, 0);

        Instantiate(meteorPrefab, positon, Quaternion.identity);
    }
}
