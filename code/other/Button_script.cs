using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_script : MonoBehaviour
{
    public BoxCollider2D coll2D;
    public BoxCollider2D coll2Dx;
    public Animator animator;
    public bool Button;
   
   

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Button == true)
        {
            coll2D.enabled = false;
            coll2Dx.enabled = true;
        }
        //checking

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 24)
        {
            animator.SetBool("Pressed", true);
            Button = true;
        }
    }
}
