using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class claw_defuse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.layer == 24)
        {
           GameObject.Find("Claw1").gameObject.layer = 8;
            GameObject.Find("Claw2").gameObject.layer = 8;
        }
    }
}
