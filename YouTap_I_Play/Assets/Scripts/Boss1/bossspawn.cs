using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossspawn : MonoBehaviour
{
    public GameObject bossship;
    // Start is called before the first frame update
    void Start()
    {
        if (spawn.count == 5)

        {
            Instantiate(bossship, new Vector3(15, Random.Range(-4f, 4f), 0), Quaternion.identity);
        }
        else
        {
           Invoke("Start", .1f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        spawnboss();
    }


    public void spawnboss()
    {
        
    }
}
