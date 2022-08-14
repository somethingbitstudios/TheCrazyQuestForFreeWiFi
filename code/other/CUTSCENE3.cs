using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUTSCENE3 : MonoBehaviour
{
    public bool button;
    public bool done;
    public Animator animator;
    public string buttonstr;
    public string cutname;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        button = GameObject.Find(buttonstr).GetComponent<Button_script>().Button;
        
        if (button == true && done == false)
        {
            animator.SetBool(cutname, true);
       
            done = true;
        }
        else
        {
            animator.SetBool(cutname, false);
        }
    }
}
