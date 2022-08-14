using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_door_trigger : MonoBehaviour
{
    public BoxCollider2D TriggerCollider2D;
    public string SceneNumString;
    public bool Triggered;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Triggered = true;
        GameObject.Find("Eprompt").GetComponent<SpriteRenderer>().enabled = true;
        if (Input.GetKey(KeyCode.E))
        {
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumString;
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
        }
        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Triggered = false;
        GameObject.Find("Eprompt").GetComponent<SpriteRenderer>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.E) && Triggered == true)
        {
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumString;
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
        }
    }
}
