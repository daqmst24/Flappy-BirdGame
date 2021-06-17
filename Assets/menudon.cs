using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menudon : MonoBehaviour
{
    void dondur()
    {
        SceneManager.LoadScene(0);
    }
    void Start()
    {
        Invoke("dondur", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
