using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemyPrefeb;
    public GameObject arrowPrefeb;
    public GameObject player;

    private float time = 1.5f;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        time -= Time.deltaTime;

        if(time < 0)
        {
            GameObject enemy = Instantiate(enemyPrefeb) as GameObject;
            float posX = Random.Range(-10.0f, 10.0f);
            float posZ = Random.Range(-10.0f, 10.0f);
            enemy.transform.position = new Vector3(posX, 0, posZ);

            GameObject arrow = Instantiate(arrowPrefeb, player.transform);
            arrow.GetComponent<arrow>().target = enemy.gameObject;

            time = 1.5f;
        }
    }
}
