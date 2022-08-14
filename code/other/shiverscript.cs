using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiverscript : MonoBehaviour
{
    bool shiver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shiver == true)
        {
            transform.position += new Vector3(0, 1, 0);
            shiver = false;
        }
        else
        {
            transform.position += new Vector3(0, -1, 0);
            shiver = true;
        }
        
    }
}
