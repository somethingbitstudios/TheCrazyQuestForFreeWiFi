using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_script : MonoBehaviour
{
    public BoxCollider2D coll2D;
    public Animator animator;
    public bool button;
    public string buttonstr;
    // Start is called before the first frame update
    void Start()
    {
        coll2D = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        button = GameObject.Find(buttonstr).GetComponent<Button_script>().Button;
        if (button == true)
        {
            coll2D.enabled = false;
            animator.SetBool("open", true);
        }
        else
        {
            coll2D.enabled = true;
            animator.SetBool("open", false);
        }
    }
}
