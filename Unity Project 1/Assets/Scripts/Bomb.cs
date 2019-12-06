using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{


   //The majority of this code is from the tutorial video however, has been edited for my own use see next text line//



    public float explosionForce = 10;
    public float explosionRadius = 5;
    public float fuseCountdown = 3;
    public bool litfuse = false;

    [SerializeField]
    public GameObject bomb;




         


  

    //if anything is shot at the bomb it will blow up
    private void OnTriggerEnter(Collider other)
    {
        SelfDestruct(); 
    }


    //this is the code from the tutorial video that does the physics to blow things away.
    
 
             void SelfDestruct()
            {
                Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

                foreach (Collider collider in colliders)
                {
                    Rigidbody r = collider.GetComponent<Rigidbody>();
                    if (r != null)
                    {
                        r.AddExplosionForce(explosionForce, transform.position, explosionRadius, 0, ForceMode.Impulse);
                    }
                }

                Destroy(gameObject);
            }

        

    

}
