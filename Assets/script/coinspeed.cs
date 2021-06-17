using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinspeed : MonoBehaviour
{
    public float speed;

 

    private void Start()
    {
        Destroy(gameObject,15);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
 


}
