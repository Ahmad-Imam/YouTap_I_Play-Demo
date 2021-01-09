using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyanim : MonoBehaviour
{
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        int aa = Random.Range(0, 4);
        //Debug.Log(aa);
        if(aa==0)
        {
            _anim.SetInteger("anim1",0);
        }
        if (aa == 1)
        {
            _anim.SetInteger("anim1", 1);
        }
        if (aa == 2)
        {
            _anim.SetInteger("anim1", 2);
        }
        if (aa == 3)
        {
            _anim.SetInteger("anim1", 3);
        }
    }
}
