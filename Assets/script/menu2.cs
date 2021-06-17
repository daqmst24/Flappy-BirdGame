using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu2 : MonoBehaviour
{

    public GameObject game;
    public GameObject skor;
    public GameObject Market;
  
  public void basla()
    {

        Time.timeScale = 1;
        game.SetActive(false);
        skor.SetActive(true);
        GameManager.gameState = true;
    }
    public void market()
    {
        game.SetActive(false);
        Market.SetActive(true);
    }
    public void Back()
    {
        Market.SetActive(false);
        game.SetActive(true);


    }

}
