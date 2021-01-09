using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IIlaser : MonoBehaviour
{
   // public GameObject IIlboss;
    public float IIlspeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        IIbosslaser();


    }
    public void IIbosslaser()
    {
        
        transform.Translate(Vector3.left * IIlspeed * Time.deltaTime);
        //Debug.Log(transform.position);
        if (transform.position.x < -4.5f)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
     
        if(collision.gameObject.tag=="player")
        {
            healthbar.health = healthbar.health - .1f;
            Playermove.playerlife--;
        }
    }


}
