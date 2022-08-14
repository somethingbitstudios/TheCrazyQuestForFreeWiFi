using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Exit()
    {
		Application.Quit();
    }
    public void SettingsToggle()
    {
        if (GameObject.Find("PlayButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("PlayButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("PlayButton").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("PlayButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("PlayButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("PlayButton").GetComponent<Button>().enabled = true;
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
        if (GameObject.Find("QuitButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("QuitButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("QuitButton").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("QuitButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("QuitButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("QuitButton").GetComponent<Button>().enabled = true;
        }


        if (GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled == true)
        {
            GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = true;
        }




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


    public void PlayToggle()
	{
        if (GameObject.Find("PlayButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("PlayButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("PlayButton").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("PlayButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("PlayButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("PlayButton").GetComponent<Button>().enabled = true;
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
        if (GameObject.Find("QuitButton").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("QuitButton").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("QuitButton").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("QuitButton").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("QuitButton").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("QuitButton").GetComponent<Button>().enabled = true;
        }


        if (GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled == true)
        {
            GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            GameObject.Find("logo").GetComponent<SpriteRenderer>().enabled = true;
        }




        if (GameObject.Find("file1").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("file1").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("file1").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("file2").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("file2").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("file2").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("file3").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("file3").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("file3").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("Button").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("Button").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("Button").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("Button").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("Button").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("Button").GetComponent<Button>().enabled = true;
        }
        if (GameObject.Find("save").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("save").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("save").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("num1").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("num1").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("num1").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("num2").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("num2").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("num2").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("num3").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("num3").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("num3").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("load1").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("load1").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("load1").GetComponent<Image>().enabled = true;
        }
        
        if (GameObject.Find("load2").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("load2").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("load2").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("load3").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("load3").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("load3").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("new1").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("new1").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("new1").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("new2").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("new2").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("new2").GetComponent<Image>().enabled = true;
        }
        if (GameObject.Find("new3").GetComponent<Image>().enabled == true)
        {
            GameObject.Find("new3").GetComponent<Image>().enabled = false;
        }
        else
        {
            GameObject.Find("new3").GetComponent<Image>().enabled = true;
        }


        if (GameObject.Find("load1").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("load1").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("load1").GetComponent<Button>().enabled = true;
        }
        if (GameObject.Find("load2").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("load2").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("load2").GetComponent<Button>().enabled = true;
        }
        if (GameObject.Find("load3").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("load3").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("load3").GetComponent<Button>().enabled = true;
        }

        if (GameObject.Find("new1").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("new1").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("new1").GetComponent<Button>().enabled = true;
        }
        if (GameObject.Find("new2").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("new2").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("new2").GetComponent<Button>().enabled = true;
        }
        if (GameObject.Find("new3").GetComponent<Button>().enabled == true)
        {
            GameObject.Find("new3").GetComponent<Button>().enabled = false;
        }
        else
        {
            GameObject.Find("new3").GetComponent<Button>().enabled = true;
        }
    }
}
