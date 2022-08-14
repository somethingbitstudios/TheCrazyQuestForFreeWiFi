using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beta_Machine_script : MonoBehaviour
{
    public bool Triggered;
    public string SceneNumString;
    public BoxCollider2D TriggerCollider2D;
    public Rigidbody2D rb;
    public float timeg;
    public bool doit;
    // Start is called before the first frame update
   
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Triggered = true;
        GameObject.Find("Eprompt").GetComponent<SpriteRenderer>().enabled = true;
        

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
            Triggered = false;
            GameObject.Find("CameraControl").GetComponent<Animator>().SetBool("is", true);
            GameObject.Find("the loading").GetComponent<Animator>().SetBool("start", true);
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
            timeg = 10;
        }

        if (timeg < 0)
        {
            AlphaEnding();
        }
        else if (timeg > 0)
        {
            timeg -= Time.deltaTime;
        }
    }
    void AlphaEnding()
    {
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumString;
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
    }
}
