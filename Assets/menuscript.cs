using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour
{


    public Text text;
    public market menu;
    public GameObject[] obje;


    public void Baslat()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    

    public void Anamenu()
    {


        SceneManager.LoadScene(0);
        Time.timeScale = 1;


    }    

}
