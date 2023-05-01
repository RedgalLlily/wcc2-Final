using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public GameObject ParticleSys;

    void Awake()
    {
        Destroy(gameObject, life);
    }

  
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("balloon"))
        {
            //Destroy(collision.gameObject);
           // ParticleSys.SetActive(true);
        }
        //Destroy(gameObject);
    }
}
