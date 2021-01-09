using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemyship;

    public GameObject ded;
    public GameObject hidone;
    public static int count=0;
    public scenemanager sc;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemyspawn());
        ded.SetActive(false);
        hidone.SetActive(false);

    }

    void Update()
    {
        /*if (IIbossmove.IIbosslife < 1)
        {
            Debug.Log("hoise?>");
            StopAllCoroutines();

            if (PlayerPrefs.GetInt("hscore") < scoreManage.score)
            {
                hidone.SetActive(true);
            }
            else
            ded.SetActive(true);

            sc.goscene(1);
        }*/
        
    }

    public IEnumerator enemyspawn()
    {
        while (true)
        {
            count++;
            Instantiate(enemyship, new Vector3(18, Random.Range(-4f, 4f), 0), Quaternion.identity);
            
           
                yield return new WaitForSeconds(1.0f);
        }
    }
}
