using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
  [SerializeField] int Distance;
  [SerializeField] int Score;
  
  public TextMeshProUGUI Score_text,Distance_Text,HighScore_text;
    void Start()
    {
     

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Distance += 1;
      Distance_Text.text = "Dis:" + Distance.ToString() + "M";
      Score += Distance/4;  
      Score_text.text = "Score:" + Score.ToString();
             if(Score<PlayerPrefs.GetInt("HighScore"))
             {
             HighScore_text.text = "HighScore:" + PlayerPrefs.GetInt("HighScore");

                 return;
             }else{
              PlayerPrefs.SetInt("HighScore",Score);

             HighScore_text.text = "HighScore:" + PlayerPrefs.GetInt("HighScore");

             }
    }
}
