using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymove : MonoBehaviour
{
    public GameObject enemy_anim;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * 5 * Time.deltaTime);
        if(transform.position.x<-4.5f)
        {
            Destroy(gameObject);
        }


    }

    public void OnTriggerEnter2D(Collider2D collided)
    {
        if (collided.gameObject.tag == ("player"))
        {
            // Debug.Log("Enemy hit player")
            
        }

        if (collided.gameObject.tag==("laser"))
            {
            Instantiate(enemy_anim, transform.position, Quaternion.identity);
            Destroy(gameObject);
            //Debug.Log("In player collider");
            animator.SetInteger("anim1",4);
            //DestroyImmediate((enemy_anim));
            scoreManage.score++;
        }
        
            
    }

}
