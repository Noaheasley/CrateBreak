using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehaviour : MonoBehaviour
{
    public float TimeInterval;
    public bool GameOver = false;
    public GameObject BoxRef;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBox());
    }

    public IEnumerator SpawnBox()
    {
        while(!GameOver)
        {
            Vector3 spawnPosition = new Vector3(transform.position.x, 0.57f , transform.position.z);
            GameObject box = Instantiate(BoxRef.gameObject, spawnPosition, new Quaternion());
            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
