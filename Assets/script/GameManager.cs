using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public int altın;
    public Text text;

    public Text Score;
    public int puan;
    public Text overtext;
    public Text Highscore;
    public int tutan;
    public Transform birdCreation;
    public GameObject[] birds;
    public static int birdIndex;

   
 
    public static bool gameState;

    void Start()
    {


        birdIndex = PlayerPrefs.GetInt("birdIndex");
        Instantiate(birds[birdIndex], birdCreation.position,Quaternion.identity);
     
        Debug.Log(birdIndex);
        Time.timeScale = 1;
        gameState = false;
        text.text = PlayerPrefs.GetInt("gold").ToString();
        altın = PlayerPrefs.GetInt("gold");
        Score.text = puan.ToString();
        Highscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore").ToString();
        overtext.text = "Score: " + tutan.ToString();

    }

   public void Scoreartır()
    {
        puan++;
 
        Score.text = puan.ToString();
        tutan = puan;

        if (puan > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", puan);
        }

        overtext.text ="Score: "+ tutan.ToString();
        Highscore.text = "HIGHSCORE: "+ PlayerPrefs.GetInt("Highscore").ToString();
    }
    public void paraartır()
    {

        altın++;

        text.text = altın.ToString();

        PlayerPrefs.SetInt("gold",altın);


    }



}
