using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    //making the options within the menu
    public GameObject start;
    public GameObject options;
    public GameObject quit;
    public GameObject res1080;
    public GameObject res800;
    public GameObject exit;





    // this code will load the scene which is the actual game level
    public void Startbutton()
    {
        SceneManager.LoadScene("FinalVersionProject04.12.19"); 
    }

    //this will hide the button within menu and then show the options button if clicked
    public void optionbutton()
    {
        start.SetActive(false);
        options.SetActive(false);
        quit.SetActive(false);
        res1080.SetActive(true);
        res800.SetActive(true);
        exit.SetActive(true);
        
    }

    //This code will exit out of the application if clicked
    public void exitbutton()
    {
        Application.Quit();
    }
    

    //these public voids are the options in the menu
    public void options1080p()
    {
        Screen.SetResolution(1080, 1920, false);
    }


    public void options800p()
    {
        Screen.SetResolution(800, 600, false);
    }


    public void optionsexitp()
    {
        start.SetActive(true);
        options.SetActive(true);
        quit.SetActive(true);
        res1080.SetActive(false);
        res800.SetActive(false);
        exit.SetActive(false);
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
