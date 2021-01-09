using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossanim : MonoBehaviour
{
    private Animator _anim1;
    // Start is called before the first frame update
    void Start()
    {
        _anim1 = GetComponent<Animator>();
        Invoke("animboss", .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void animboss()
    {
        int aaa = Random.Range(0, 2);
        Debug.Log(aaa);
        if (aaa == 0)
        {
            _anim1.SetInteger("banim", 0);
        }
        if (aaa == 1)
        {
            _anim1.SetInteger("banim", 1);
        }
        Invoke("animboss", 1f);
    }
}
