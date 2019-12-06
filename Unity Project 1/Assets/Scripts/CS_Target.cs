using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Target : MonoBehaviour
{

    [SerializeField]
    public GameObject Door;

    //this code shows that if the object tagged bullet enters the trigger area of the target it will be destroyed and then refer to the door script
     void OnCollisionEnter(Collision collision)
    {
        if (GameObject.FindWithTag("Bullet"))
        {
            Destroy(gameObject);
            Door.GetComponent<CS_Door>().opendoor();
        }

        

    }
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Linktodoor = GameObject.Find("Door").GetComponent(CS_Door);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
