using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezePlayer : MonoBehaviour
{
	public bool stop;
	// Start is called before the first frame update
	public void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.tag == "Player")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().Speed = 0;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().Canmove = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().rb.velocity = new Vector2(0, 0);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().animator.SetBool("walking", false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().animator.SetBool("idling", true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().animator.SetBool("jumping", false);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Movement_wall_drone1>().animator.SetBool("falling", false);
           
        }
		
		



	}
    public void Update()
	{
       
	}
}
