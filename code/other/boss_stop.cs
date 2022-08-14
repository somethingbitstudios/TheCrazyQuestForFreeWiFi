using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss_stop : MonoBehaviour
{
    public bool activated;
    GameObject varGameObject1;
    GameObject varGameObject2;
    public BoxCollider2D coll2D;
    // Start is called before the first frame update
    void Start()
    {
        varGameObject1 = GameObject.Find("Claw1");
        varGameObject2 = GameObject.Find("Claw2");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        activated = true;
        varGameObject1 = GameObject.Find("Claw1");
        varGameObject2 = GameObject.Find("Claw2");
        varGameObject1.GetComponent<Clav_script>().enabled = false;
        varGameObject2.GetComponent<Clav_script>().enabled = false;
    }
}

