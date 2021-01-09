using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermove : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    public GameObject laserprefab;
    public static int playerlife = 10;
    private Animator playeranim;
    public scenemanager sceneobj;
    public GameObject hinew;
    public GameObject dead;
    public GameObject complete;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playeranim = GetComponent<Animator>();

        hinew.SetActive(false);
        dead.SetActive(false);
        complete.SetActive(false);
    }

   
    void Update()
    {
        Debug.Log(scoreManage.score);
        if (IIbossmove.IIbosslife < 0)
        {
            Invoke("scenechange", 5);
            complete.SetActive(true);
            transform.position= new Vector3(0,25,0);
            //Destroy(gameObject);
            

        }
        if (gameObject.transform.position.y > -5.5f)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (playerlife > 0 && IIbossmove.IIbosslife >0)
                {
                    //int aa = Random.Range(0, 2);
                    // Debug.Log(aa);
                    lasercreate();
                    rb.velocity = Vector2.up * velocity;
                }
            }
        }
        if((playerlife<1)||gameObject.transform.position.y<-5.5f)
        {
            playeranim.SetInteger("expstart", 1);
            //Destroy(gameObject);
            Invoke("scenechange", 5);
            //scenechange();
            healthbar.healthbarr.fillAmount = 0.0f;

            if (PlayerPrefs.GetInt("hscore") < scoreManage.score)
            {
                hinew.SetActive(true);
                dead.SetActive(false);
            }
            else
            {
                dead.SetActive(true);
            }
        }
        //Debug.Log(playerlife);
        
    }

    public void lasercreate()
    {
        Instantiate(laserprefab,transform.position + new Vector3(.65f,0,0), Quaternion.identity);
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            healthbar.health = healthbar.health - .1f;
            playerlife--;
            //Debug.Log("ojkewrnbgv");
        }

    }
    public void scenechange()
    {
        sceneobj.goscene(2);
    }

}
