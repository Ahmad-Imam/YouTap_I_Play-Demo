using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{
    public static int bosslife = 10;
    public GameObject boss_anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        if (transform.position.x < -4.5f)
        {
            Destroy(gameObject);
        }
        if (bosslife < 1)
        {
            scoreManage.score = scoreManage.score + 5;
            Instantiate(boss_anim, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        //Debug.Log(bosslife);

    }

    public void OnTriggerEnter2D(Collider2D collided)
    {
        if (collided.gameObject.tag == ("player"))
        {
            bosslife--;
            healthbar.health = healthbar.health - .1f;
            Playermove.playerlife--;
        }

        if (collided.gameObject.tag == ("laser"))
        {
            bosslife--;
           // Debug.Log("In player boss");
        }


    }

}
