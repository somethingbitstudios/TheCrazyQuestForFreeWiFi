using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EagleControll : MonoBehaviour
{
    bool shiver;
    public float timer;
    public float SceneTimer;
    public string fred;
    // Start is called before the first frame update
    void Start()
    {
        shiver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(shiver == false)
        {
transform.position += new Vector3(0, -0.1f, 0);
        }
        

        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (shiver == true)
        {
            GameObject.FindGameObjectWithTag("boom").GetComponent<shiverscript>().enabled = false;
            
        }
        else
        {
            

            GameObject.FindGameObjectWithTag("black").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.FindGameObjectWithTag("boom").GetComponent<SpriteRenderer>().enabled = true;
            timer = 1;
            shiver = true;
        }

        if (SceneTimer > 0)
        {
            SceneTimer -= Time.deltaTime;
        }
        else
        {
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = "002";
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
            
        }

    }
}
