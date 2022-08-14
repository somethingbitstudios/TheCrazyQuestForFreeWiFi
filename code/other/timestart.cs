using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timestart : MonoBehaviour
{
    public int chbasetime;
    private float time;
    public int displaytimer;
    public bool Trigg;
   public BoxCollider2D box;
    public SpriteRenderer spri;
    // Start is called before the first frame update
    void Start()
    {
        time = chbasetime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Trigg == true)
        {
            time -= Time.deltaTime;
            displaytimer = (int)time;
        }
        if (displaytimer < 0)
        {
            box.enabled = true;
            GameObject.Find("clock").GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Trigg = true;
        GameObject.Find("clock").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("clock").GetComponent<Animator>().SetBool("trigg", true);
    }
}
