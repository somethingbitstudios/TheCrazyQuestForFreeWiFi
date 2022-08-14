using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUTSCENEMANAGER : MonoBehaviour
{
    public bool button;
    public bool button2;

    public bool done;
    public bool done2;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button = GameObject.Find("button").GetComponent<Button_script>().Button;
        button2 = GameObject.Find("button2").GetComponent<Button_script>().Button;

        if (button == true && done == false)
        {
            animator.SetBool("CUT3", true);
       
            done = true;
        }
        else
        {
            animator.SetBool("CUT3", false);
        }
        if (button2 == true && done2 == false)
        {
            animator.SetBool("CUT2", true);

            done2 = true;
        }
        else
        {
            animator.SetBool("CUT2", false);
        }
    }
}
