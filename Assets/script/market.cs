using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class market : MonoBehaviour
{
    public int para;
    public string[] kusismi;
    public int[] kusfiyati;
    public GameObject[] kus;
    public Text[] text;
    public bool alındı;
    public bool alındı1;
    public bool alındı2;
    public GameObject ALTIN;
    public GameObject ALTIN2;
    public GameObject[] skor;
    public Text SKOR;
    public static int sayı, sayı1;


    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        for (int i = 0; i < kusismi.Length; i++)
        {

    
        if (PlayerPrefs.GetInt("sayı")==1)
        {

                kusfiyati[1] = 0;
                text[1].text = "";
  

            ALTIN.SetActive(false);
         

        }
            if (PlayerPrefs.GetInt("sayı1")==1)
            {

                kusfiyati[2] = 0;
                text[2].text = "";


                ALTIN2.SetActive(false);

            }
        }
    }
    void Start()
    {
        para = PlayerPrefs.GetInt("gold");
        SKOR.text = PlayerPrefs.GetInt("gold").ToString();
    
        skor[0].SetActive(false);
    }

        

  
    public void satınal(string isim)
    {
        for (int i = 0; i < kusismi.Length; i++)
        {
            if (isim == "sarıbird")
            {
                if (kusismi[i] == isim)
                {
                    if (para >= kusfiyati[i])
                    {
                        para -= kusfiyati[i];
                        kusfiyati[0] = 0;
                        PlayerPrefs.SetInt("kus0", kusfiyati[0]);
                        GameManager.birdIndex = 0;
                        PlayerPrefs.SetInt("birdIndex", GameManager.birdIndex);
                   
                    
                      
                        
                        alındı = true;
                        SceneManager.LoadScene(1);
                    }
                }
            }
            if (isim == "RedBird")
            {
                if (kusismi[i] == isim)
                {

                    if (para >= kusfiyati[i] )
                    {

                        sayı = 1;
                        GameManager.birdIndex = 1;
                        para -= kusfiyati[i];
                        PlayerPrefs.SetInt("gold", para);
                        PlayerPrefs.SetInt("birdIndex", GameManager.birdIndex);
                        
                        kusfiyati[1] = 0;
                        PlayerPrefs.SetInt("kus1", kusfiyati[1]);
                        alındı1 = true;
                        text[1].text = "";
                        ALTIN.SetActive(false);
                        PlayerPrefs.SetString("tutuldu2", text[1].text);
                        SceneManager.LoadScene(1);
                        PlayerPrefs.SetInt("sayı", 1);


                    }
                }
            }
            if (isim == "BlueBird")
            {
                if (kusismi[i] == isim)
                {
                    if (para >= kusfiyati[i])
                    {
                        sayı1 = 1;
                        GameManager.birdIndex = 2;
                        para -= kusfiyati[i];
                        PlayerPrefs.SetInt("gold", para);
                        PlayerPrefs.SetInt("birdIndex", GameManager.birdIndex);
                
                        kusfiyati[2] = 0;
                        PlayerPrefs.SetInt("kus2",kusfiyati[2]);
                         alındı2 = true;
                        PlayerPrefs.SetInt("sayı1", 1);
                        ALTIN2.SetActive(false);
                        PlayerPrefs.SetString("tutuldu2", text[2].text);
                        SceneManager.LoadScene(1);

                        text[2].text = "";
                    }
                }
            }
        }
    }
    }


            
        
        




