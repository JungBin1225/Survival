using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefeb;
    public GameObject rangeEnemy;

    private BoxCollider range;
    private bool inRange;
    private int spawnType;
    private float time = 1.5f;

    void Start()
    {
        range = GetComponent<BoxCollider>();
        inRange = false;
    }

    void Update()
    {
        if(inRange)
        {
            SpawnEnemy();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inRange = false;
        }
    }

    private void SpawnEnemy()
    {
        if (!GameManager.gameManager.isCutScene)
        {
            time -= Time.deltaTime;
            spawnType = Random.Range(1, 3);
            if (time < 0)
            {
                if (spawnType == 1)
                {
                    GameObject enemy = Instantiate(enemyPrefeb) as GameObject;
                    float locX = transform.position.x;
                    float locZ = transform.position.z;

                    float posX = Random.Range(locX - (range.size.x / 2), locX + (range.size.x / 2));
                    float posZ = Random.Range(locZ - (range.size.z / 2), locZ + (range.size.z / 2));
                    enemy.transform.position = new Vector3(posX, 0, posZ);

                    time = 1.5f;
                }
                else if (spawnType == 2)
                {
                    GameObject enemy = Instantiate(rangeEnemy) as GameObject;
                    float locX = transform.position.x;
                    float locZ = transform.position.z;

                    float posX = Random.Range(locX - (range.size.x / 2), locX + (range.size.x / 2));
                    float posZ = Random.Range(locZ - (range.size.z / 2), locZ + (range.size.z / 2));
                    enemy.transform.position = new Vector3(posX, 0, posZ);

                    time = 1.5f;
                }
                /* GameObject enemy = Instantiate(rangeEnemy) as GameObject;
                 float posX = Random.Range(-10.0f, 10.0f);
                 float posZ = Random.Range(-10.0f, 10.0f);
                 enemy.transform.position = new Vector3(posX, 0, posZ);*/

                time = 1.5f;
            }
        }
    }
}
