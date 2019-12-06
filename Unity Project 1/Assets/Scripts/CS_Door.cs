using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Door : MonoBehaviour
{

    public void opendoor()//this is open door
    {
        Debug.Log("Run");//check in console to see if the code works and will run
        transform.position = transform.position + new Vector3(0, 7, 0);//move the door upward to let the player through
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
