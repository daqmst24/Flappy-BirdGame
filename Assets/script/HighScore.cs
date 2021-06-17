using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text skor;
    public Text text;
 
    void Start()
    {
      skor.text= "HighScore:"+PlayerPrefs.GetInt("Highscore").ToString();

        text.text = PlayerPrefs.GetInt("gold").ToString();

   
    }



}
