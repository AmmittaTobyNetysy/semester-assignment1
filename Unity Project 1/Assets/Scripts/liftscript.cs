using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftscript : MonoBehaviour
{

    //the variables
    public float Height;
    public float Speed;

    //this shows if the lift is going up or not 
    private bool LiftUp = false;
    //this is the lifts starting position
    private float StartY;


    //this shows the code that it will move from its starting position upward
    private void Awake()
    {
        StartY = transform.position.y;
    }


    //this code will only run if the player runs through it and nothing else
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") == false)
            return;

        LiftUp = true;
    }

    //this will run the code and will thransform the original position to upward with its relative speed and will go to its max height

    private void Update()
    {
        if(LiftUp &&
            transform.position.y < StartY + Height)
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
    }


}
