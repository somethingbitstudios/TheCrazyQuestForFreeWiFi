using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_start : MonoBehaviour
{
    public bool activated;
    GameObject varGameObject1;
    GameObject varGameObject2;
    public BoxCollider2D coll2D;
    public AudioClip change;
    // Start is called before the first frame update
    void Start()
    {
        varGameObject1 = GameObject.Find("Claw1");
        varGameObject2 = GameObject.Find("Claw2");
        activated = false;
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(activated == false)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().clip = change;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();
        }
        
        activated = true;
        varGameObject1 = GameObject.Find("Claw1");
        varGameObject2 = GameObject.Find("Claw2");
        varGameObject1.GetComponent<Clav_script>().enabled = true;
        varGameObject2.GetComponent<Clav_script>().enabled = true;
        
    }
    }
