using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLoad : MonoBehaviour
{
    public BoxCollider2D TriggerCollider2D;
    public string SceneNumString;
    public bool Triggered;
    public float delay;
    public bool OnlyPLR;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(OnlyPLR == false || collision.gameObject.layer == 24)
        {
Triggered = true;
        if (delay == 0)
        {
 GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumString;
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
        }
        }
        
       
    }
    private void Update()
    {
        if (Triggered)
        {
            if(delay > 0)
            {
                delay -= Time.deltaTime;

            }
            else
            {
                GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumString;
                GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
            }
        }
    }

}
