using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIscript : MonoBehaviour
{
    public GameObject GoalText;
    public GameObject WinText;

    public TMP_Text CountText;
    public TMP_Text TimeText;

    int PumpkinCount;
    float TimeCount;
    int TimeInt;

    void Start()
    {
        
    }


   
    void Update()
    {

        PumpkinCount = GameObject.FindGameObjectsWithTag("pumpkin").Length;
        CountText.SetText("Pumpkins left: " + PumpkinCount);

        if (GameObject.FindGameObjectsWithTag("pumpkin").Length > 0)
        {
            TimeCount += Time.deltaTime;
            TimeInt = (int)TimeCount;
        }
           
        TimeText.SetText("Time passed: " + TimeInt + " seconds");


        if (GameObject.FindGameObjectsWithTag("pumpkin").Length <= 0)
        {
            GoalText.gameObject.SetActive(false);
            WinText.gameObject.SetActive(true);
        }



    }
}
