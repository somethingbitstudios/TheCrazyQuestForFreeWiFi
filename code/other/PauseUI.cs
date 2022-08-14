using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseUI : MonoBehaviour
{
    public bool active;
    
    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.Find("ResumeButton").GetComponent<Image>().enabled == true || GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled == true)
        {
            Cursor.visible = true;
        }
        else
        {
            Cursor.visible = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            
            Resume();
        }
        
    }
    public void MainMenu()
    {
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = "000";
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
    }
    public void Resume()
    {
        PauseToggle();
        GameObject.Find("Slider1").GetComponent<Slider>().enabled = false;
        GameObject.Find("Slider").GetComponent<Slider>().enabled = false;
        GameObject.FindGameObjectWithTag("icon").GetComponent<Image>().enabled = false;
        GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().enabled = false;
        GameObject.FindGameObjectWithTag("Slider").GetComponent<Image>().enabled = false;
        GameObject.Find("BackImage").GetComponent<Image>().enabled = false; GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled = false;
         GameObject.Find("Checkmark").GetComponent<Image>().enabled = false;
           GameObject.Find("BackGround").GetComponent<Image>().enabled = false;
         GameObject.Find("Handle").GetComponent<Image>().enabled = false;
        GameObject.Find("volumeIcon").GetComponent<Image>().enabled = false;
        GameObject.Find("fullIcon").GetComponent<Image>().enabled = false;
        GameObject.Find("Background").GetComponent<Image>().enabled = false;


    }
    public void PauseToggle()
    {
        if (GameObject.Find("pause1").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("pause1").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("pause1").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("pause2").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("pause2").GetComponent<Image>().enabled = false;
            
        }
        else
        {
            GameObject.Find("pause2").GetComponent<Image>().enabled = true;
        }





        if (GameObject.Find("ResumeButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("ResumeButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("ResumeButton").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("ResumeButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("ResumeButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("ResumeButton").GetComponent<Button>().enabled = true;
        }


        if (GameObject.Find("SettingsButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("SettingsButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("SettingsButton").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("SettingsButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("SettingsButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("SettingsButton").GetComponent<Button>().enabled = true;
        }




        if (GameObject.Find("ToMainMenuButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("ToMainMenuButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("ToMainMenuButton").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("ToMainMenuButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("ToMainMenuButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("ToMainMenuButton").GetComponent<Button>().enabled = true;
        }

        //if (active == true)
       // {
          //  active = false;




          //  GameObject.Find("BackImage").GetComponent<Image>().enabled = false; GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled = false;
        //    GameObject.Find("Checkmark").GetComponent<Image>().enabled = false;
         //   GameObject.Find("BackGround").GetComponent<Image>().enabled = false;
          //  GameObject.Find("Handle").GetComponent<Image>().enabled = false;






          //  GameObject.Find("SettingsButton (1)").GetComponent<Button>().enabled = false;
   //     }


    }
    public void SettingsToggle()
    {
        
        
        PauseToggle();
        if (GameObject.Find("BackImage").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("BackImage").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("BackImage").GetComponent<Image>().enabled = true;
        }



        if (GameObject.Find("Slider").GetComponent<Slider>().enabled == true)
        {
            GameObject.Find("Slider").GetComponent<Slider>().enabled = false;
        }
        else
        {
            GameObject.Find("Slider").GetComponent<Slider>().enabled = true;
        }


        if (GameObject.Find("Slider1").GetComponent<Slider>().enabled == true)
        {
            GameObject.Find("Slider1").GetComponent<Slider>().enabled = false;

        }
        else
        {
            GameObject.Find("Slider1").GetComponent<Slider>().enabled = true;
        }




        if (GameObject.Find("Toggle").GetComponent<Toggle>().enabled == true)
        {
            GameObject.Find("Toggle").GetComponent<Toggle>().enabled = false;
        }
        else
        {
            GameObject.Find("Toggle").GetComponent<Toggle>().enabled = true;
        }


        if (GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("SettingsButton (1)").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("SettingsButton (1)").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("SettingsButton (1)").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("SettingsButton (1)").GetComponent<Button>().enabled = true;
        }


        if (GameObject.Find("Checkmark").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("Checkmark").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("Checkmark").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("BackGround").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("BackGround").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("BackGround").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("Background").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("Background").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("Background").GetComponent<Image>().enabled = true;
        }

        if (GameObject.Find("Handle").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("Handle").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("Handle").GetComponent<Image>().enabled = true;
        }



        if (GameObject.Find("volumeIcon").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("volumeIcon").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("volumeIcon").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("fullIcon").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("fullIcon").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("fullIcon").GetComponent<Image>().enabled = true;
        }


        if (GameObject.FindGameObjectWithTag("Slider").GetComponent<Image>().enabled == true)
        {
            GameObject.FindGameObjectWithTag("Slider").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Slider").GetComponent<Image>().enabled = true;
        }
        if (GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().enabled == true)
        {
            GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().enabled = false;

        }
        else
        {
            GameObject.FindGameObjectWithTag("Handle").GetComponent<Image>().enabled = true;
        }


        if (GameObject.FindGameObjectWithTag("icon").GetComponent<Image>().enabled == true)
        {
            GameObject.FindGameObjectWithTag("icon").GetComponent<Image>().enabled = false;

        }
        else
        {
            GameObject.FindGameObjectWithTag("icon").GetComponent<Image>().enabled = true;
        }





    }
}
