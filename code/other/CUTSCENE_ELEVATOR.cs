using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUTSCENE_ELEVATOR : MonoBehaviour
{
    public float basedtime;
    public float time;
    public BoxCollider2D box;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        time = basedtime;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        else
        {
            box.enabled = false;
            anim.SetBool("break", true);
        }
    }
}
