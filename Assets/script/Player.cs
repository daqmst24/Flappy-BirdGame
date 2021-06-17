using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{

    //para tutumu
    int para;
    public GameObject _pARA;
    public Text paraskor;


   

    Rigidbody2D rg;
    public float jumpspeed;
    public bool isDead;

    public GameObject mani;

    public GameManager manger;
    public AudioClip Jump;
    public AudioClip Dead;
    public AudioClip Coin;
    public AudioClip Para;

    public GameObject gameover;
    public GameObject sayac;
   
    AudioSource muzik;

    public int puan;

    void Start()
    {
        Invoke("StopTime",0.0f);
        muzik = gameObject.GetComponent<AudioSource>();
        rg = GetComponent<Rigidbody2D>();
        gameover = GameObject.FindGameObjectWithTag("Canvas");
        _pARA = GameObject.FindGameObjectWithTag("ParaSpawner");
        paraskor = GameObject.FindGameObjectWithTag("ParaScore").GetComponent<Text>();
        mani = GameObject.FindGameObjectWithTag("mani");
        manger = GameObject.FindGameObjectWithTag("manger").GetComponent<GameManager>();
        sayac = GameObject.FindGameObjectWithTag("Sayac");

    }
    void StopTime()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.timeScale==1)
            {

         
            muzik.PlayOneShot(Jump);
            }
            rg.velocity = Vector2.up * jumpspeed;
         

           
            
        }
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name== "Coin")
        {
            muzik.PlayOneShot(Coin);
            manger.Scoreartır();

           
       

        }
   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "COin")
        {
            muzik.PlayOneShot(Para);
            Destroy(collision.gameObject);
            manger.paraartır();



        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="boru")
        {
      
            muzik.PlayOneShot(Dead);
            Time.timeScale = 0;
            gameover.SetActive(true);
          
            sayac.SetActive(false);
            GameManager.gameState = false;
            Debug.Log(GameManager.gameState);
        }
      
    }




}
