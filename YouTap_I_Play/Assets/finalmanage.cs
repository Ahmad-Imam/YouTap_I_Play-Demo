using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalmanage : MonoBehaviour
{
    public Text finalScore;
    public Text HiScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore.text = "final score  "+ scoreManage.score;
        

        if (PlayerPrefs.GetInt("hscore") < scoreManage.score)
        {
            Debug.Log("hihasd");
           
            PlayerPrefs.SetInt("hscore", scoreManage.score);
        }
        HiScore.text = "high score is " + PlayerPrefs.GetInt("hscore");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
