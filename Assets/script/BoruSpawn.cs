using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruSpawn : MonoBehaviour
{
    public Player play;
    public GameObject borular;
    public float height;
    public float time;
    float value = 0;
    private void Start()
    {
       
    }
   

    public void Update()
    {
        if (play == null)
        {
            play = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Player>();
        }
        if (GameManager.gameState == true)
        {
            if (value < time)
            {
                value += 0.01f;
            }
            else
            {
                value = 0;
                Instantiate(borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            }
        }
    }
}
