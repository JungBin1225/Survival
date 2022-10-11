using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject target;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        Vector3 dir = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        transform.LookAt(dir);
    }
}
