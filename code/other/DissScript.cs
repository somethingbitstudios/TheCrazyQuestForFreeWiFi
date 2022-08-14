using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissScript : MonoBehaviour
{
    public BoxCollider2D coll2D;
    public Animator animator;  
    public bool Break;
    public LayerMask PlayerLayer;
    public float BreakTime;
    public float BaseTime;
    
    // Start is called before the first frame update
    void Start()
    {
       coll2D = GetComponent<BoxCollider2D>();
        BreakTime = BaseTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (Break == true)
        {
            if (BreakTime < 0)
            {
                coll2D.enabled = false;
                animator.SetBool("Break", false);
            }
            else
            {
                BreakTime -= Time.deltaTime;
            }
        }
        //checking

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 24)
        {
            animator.SetBool("Break", true);
            Break = true;
        }
    }
}
