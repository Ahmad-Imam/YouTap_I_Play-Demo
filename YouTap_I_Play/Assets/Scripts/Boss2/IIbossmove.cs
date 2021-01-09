using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IIbossmove : MonoBehaviour
{
    public static int IIbosslife = 20;
    public GameObject IIboss_anim;
    public GameObject IIlaserprefab;
    public float delay = 0.01f;
    public float fireRate = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BossFire", delay, fireRate);
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(bosslife);

    }

    void BossFire()
    {
        gameObject.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        if (transform.position.x < -4.5f)
        {
            Destroy(gameObject);
        }
        if (IIbosslife < 1)
        {
            scoreManage.score = scoreManage.score + 5;
            Instantiate(IIboss_anim, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (IIbosslife < 50)
        {
            IIlasercreate();
        
        }
    }

    public void OnTriggerEnter2D(Collider2D collided)
    {
        if (collided.tag == ("player"))
        {
            IIbosslife--;
            
            //Debug.Log("boss hit player");
        }

        if (collided.tag == ("laser"))
        {
           IIbosslife--;
            //Debug.Log("In player boss");

        }

        
    }

    public void IIlasercreate()
    {
        Instantiate(IIlaserprefab, transform.position + new Vector3(-2.1f, 0, 0), Quaternion.identity);
        //Invoke("IIlasercreate",2f);
    }

}
