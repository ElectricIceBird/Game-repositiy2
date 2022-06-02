using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayManager : MonoBehaviour
{
    public static bool gameover = false;
    public GameObject goPanel;

    int adInt;


    public static bool isStarted;
    public GameObject startText,Score_text,Distance_text;
    public ScoreScript SC;
    // Start is called before the first frame update
    void Start()
    {

        gameover = false;
        SC.enabled = false;
        Time.timeScale = 1;
        isStarted = false;
            admanager.instance.RequestAdinter();
        adInt = Mathf.RoundToInt(Random.Range(0f,3f));



    }


    // Update is called once per frame
    void Update()
    {

       if (gameover)
        {
            Time.timeScale = 0;
            goPanel.SetActive(true);

            Destroy(Score_text);
            Destroy(Distance_text);
            if(adInt==0)
            {
            admanager.instance.showInter();
            }

        }
        if (SwipeManager.tap)
        {
            isStarted = true;
            Destroy(startText);
        SC.enabled = true;


        }
    }
}
