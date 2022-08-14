﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralaxY : MonoBehaviour
{
    private float startpos;
    public float lenght;
    public GameObject cam;
    public float parallaxEffect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.y - cam.transform.position.y * parallaxEffect;
        lenght = GetComponent<SpriteRenderer>().bounds.size.y;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        float dist = (cam.transform.position.y * parallaxEffect);
        transform.position = new Vector3(transform.position.x, startpos + dist, transform.position.z);

    
    }
}
