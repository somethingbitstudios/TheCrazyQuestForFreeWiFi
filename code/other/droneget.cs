using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneget : MonoBehaviour
{
    public string SceneNumStr;
    public bool yee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        yee = true;
       // GameObject.Find("Player").GetComponent<Movement_wall>().HasDrone = true;
        GameObject.Find("drone").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = SceneNumStr;
        GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
    }
}
