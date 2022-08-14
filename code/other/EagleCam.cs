using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleCam : MonoBehaviour
{
    public Rigidbody2D rb;
    public float time1;
    public float time2;
    public float time3;
    public float time4;
    public float time5;
    public float time6;
    public float time7;
    public float time8;
    public float time9;
    public float time10;
    public float time;
    public int index; 
    // Start is called before the first frame update
    void Start()
    {
        index = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
        }
        if (time < 0)
        {
            if(index == 1)
            {
                time = time1;
                index = 2;
            }
            else if (index == 2)
            {
                time = time2;
                index = 3;
            }
            else if (index == 3)
            {
                time = time3;
                index = 4;
            }
            else if (index == 4)
            {
                time = time4;
                index = 5;
            }
            else if (index == 5)
            {
                time = time5;
                index = 6;
            }
            else if (index == 6)
            {
                time = time6;
                index = 7;
            }

            else if (index == 7)
            {
                time = time7;
                index = 8;
            }
            else if (index == 8)
            {
                time = time8;
                index = 9;
            }
            else if (index == 9)
            {
                time = time9;
                index = 10;
            }
            else if (index == 10)
            {
                time = time10;
                index = 11;
            }
        }

        if (index == 1)
        {
            transform.position += new Vector3(-12 * Time.deltaTime, 3 * Time.deltaTime, 0);
            transform.localScale = new Vector2(1, 1);
        }
        if (index == 2)
        {
            transform.position += new Vector3(12 * Time.deltaTime, -7 * Time.deltaTime, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        if (index == 3)
        {
            transform.position += new Vector3(-12 * Time.deltaTime, 0 * Time.deltaTime, 0);
            
        }
        if (index == 4)
        {
            transform.position += new Vector3(0 * Time.deltaTime, 11 * Time.deltaTime, 0);
        }
        if (index == 5)
        {
            transform.position += new Vector3(-10 * Time.deltaTime, 0 * Time.deltaTime, 0);
        }
        if (index == 6)
        {
            transform.position += new Vector3(10 * Time.deltaTime, -4 * Time.deltaTime, 0);
            transform.localScale = new Vector2(-1, -1);
        }
        if (index == 7)
        {
            transform.position += new Vector3(-3 * Time.deltaTime, 8 * Time.deltaTime, 0);
        }
        if (index == 8)
        {
            transform.position += new Vector3(0 * Time.deltaTime, -20 * Time.deltaTime, 0);
        }
        if (index == 9)
        {
            transform.position += new Vector3(0 * Time.deltaTime, 0 * Time.deltaTime, 0);
        }
        
    }
}
