using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetActiveFalse : MonoBehaviour
{
    private void Start()
    {
        Invoke("FalseSetActive",0.0f);
       
    }
    void FalseSetActive()
    {
        gameObject.SetActive(false);
    }
  
}
