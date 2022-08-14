using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carApearScript : MonoBehaviour
{
    public Rigidbody2D plr;
    public Rigidbody2D rb;
    public GameObject camRefPos;
    public float speed;
    public float time;
    public float drivetime;
    public bool IsIn;
    public float stime;
    public bool song;
    public AudioClip change;
    public AudioClip origi;
    public SpriteRenderer sprt;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0, 0);
        rb.position = new Vector2(camRefPos.transform.position.x + 17.87f, 0.45f);
        rb.velocity = new Vector2(0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (stime > 0)
        {
            stime -= Time.deltaTime;

        }
        else if (song == true && IsIn == false)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().clip = origi;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();
            song = false;
        
    }
        else if (song == false && IsIn == true)
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().clip = change;
            GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>().Play();
            song = true;

        }
        if (IsIn == true)
        {
            
            rb.velocity = new Vector2(-speed, 0);
            if(time < 0)
            {
                if (rb.position.x < camRefPos.transform.position.x - 32)
                {
                    sprt.enabled = false;
                    rb.position = new Vector2(camRefPos.transform.position.x + 18.87f, -133.45f);
                    time = drivetime;
                }
                
            }
            else if (time < drivetime - 0.1f)
            {
                sprt.enabled = true;
                time -= Time.deltaTime;
            }
            else
            {
                
                time -= Time.deltaTime;
            }
            
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        stime = 1;
        if (collision.tag == "Player")
        {
            IsIn = true;
        }
       

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        stime = 1;
        if (collision.tag == "Player")
        {
            IsIn = false;
        }
        
        
       
    }
}
