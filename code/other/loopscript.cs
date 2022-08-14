using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public int startvec;
    public float speed;
    public float baselooptime;
    public float looptime;
    // Start is called before the first frame update
    void Start()
    {
        looptime = baselooptime;
    }

    // Update is called once per frame
    void Update()
    {
        if (looptime < 0)
        {
            looptime = baselooptime;
            if (startvec < 3)
            {
                startvec += 1;
            }
            else
            {
                startvec = 0;
            }
        }
        else
        {
            looptime -= Time.deltaTime;
            if(startvec == 0)
            {
                rb.velocity = new Vector2(speed, 0);
            }
            else if (startvec == 1)
            {
                rb.velocity = new Vector2(0, speed);
            }
            else if (startvec == 2)
            {
                rb.velocity = new Vector2(-speed, 0);
            }
            else if (startvec == 3)
            {
                rb.velocity = new Vector2(0, -speed);
            }
        }
    }
}
