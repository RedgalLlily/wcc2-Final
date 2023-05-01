using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonExplode : MonoBehaviour
{
    public GameObject ParticleSys;
    
    public void jihuo()
    {
        gameObject.SetActive(true);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            //Activate particle system before explosion
            Invoke("jihuo",5);
            
            //Activate particle systems where collisions are formed
            Vector3 vector3 = collision.transform.position;
            var lizi = Instantiate(ParticleSys, vector3, Quaternion.identity);
            
            gameObject.SetActive(false);
        }

    }
}
