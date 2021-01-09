using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    //public GameObject ldes;
    public float lspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.right * lspeed * Time.deltaTime);
        if (transform.position.x > 14.6f)
        {
            Destroy(gameObject);
        }


    }

}
