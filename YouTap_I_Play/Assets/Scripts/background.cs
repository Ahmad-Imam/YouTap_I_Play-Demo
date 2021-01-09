using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    public int lspeed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * lspeed * Time.deltaTime);

        if (transform.position.x <-12.23f)
            transform.position = new Vector3(23.24f, transform.position.y, 0);

    }
}
