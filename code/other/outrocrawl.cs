using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outrocrawl : MonoBehaviour
{
    public Rigidbody2D rb;

    public float time0;
    public float time1;
    public float time2;
    public float time3;
    public float time4;
    public float time5;
    public float time6;
    public float time7;
    public float time8;
    public float time9;
    
    public float time;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        time = time0;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            if(index == 0)
            {
                time = time1;
                index += 1;
            }
            else if (index == 1)
            {
                time = time2;
                index += 1;
            }
            else if (index == 2)
            {
                time = time3;
                index += 1;
            }
            else if (index == 3)
            {
                time = time4;
                index += 1;
            }
            else if (index == 4)
            {
                time = time5;
                index += 1;
            }
            else if (index == 5)
            {
                time = time6;
                index += 1;
            }
            else if (index == 6)
            {
                time = time7;
                index += 1;
            }
            else if (index == 7)
            {
                time = time8;
                index += 1;
            }
            else if (index == 8)
            {
                time = time9;
                index += 1;
            }
            
            }


        if (index == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }
        else if (index == 1)
        {
            rb.velocity = new Vector2(5,-5);
        }
        else if (index == 2)
        {
            rb.velocity = new Vector2(5, 0);
        }
        else if (index == 3)
        {
            rb.velocity = new Vector2(5, 1);
        }
        else if (index == 4)
        {
            rb.velocity = new Vector2(7, 0);
        }
        else if (index == 5)
        {
            rb.velocity = new Vector2(10, rb.velocity.y);
        }
        else if (index == 6)
        {
            rb.velocity = new Vector2(5,-1);
        }
        else if (index == 7)
        {
            rb.velocity = new Vector2(6, 0);
        }
        else if (index == 8)
        {
            rb.velocity = new Vector2(20, 0);
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().SceneIndex = "022";
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
        }










    }
}

