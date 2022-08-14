using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Respawn : MonoBehaviour
{
    public Rigidbody2D rb;
    public LayerMask DieLayer;
    public bool Dead;
    
    public Transform Respawn_point1;
    public Transform Respawn_point2;
    public Transform Respawn_point3;
    public Transform Respawn_point4;
    public Transform Respawn_point5;
    public Animator ani;
    int CheckPointNum;

    public AudioSource ded;
  

    // Start is called before the first frame update
    void Start()
    {
        Dead = false;
        CheckPointNum = 1;
    }

    // Update is called once per frame
    void Update()
    {

       
        if (Dead)
        {
            
            ani.SetBool("ded", true);
            GameObject.Find("SaveManagerObject").GetComponent<SaveHandler>().LoadLevel();
            rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;


            if (CheckPointNum == 1)
            {
                transform.position = Respawn_point1.position;
            }
            else if (CheckPointNum == 2)
            {
                transform.position = Respawn_point2.position;
            }
            else if (CheckPointNum == 3)
            {
                transform.position = Respawn_point3.position;
            }
            else if (CheckPointNum == 4)
            {
                transform.position = Respawn_point4.position;
            }
            else if (CheckPointNum == 5)
            {
                transform.position = Respawn_point5.position;
            }
            
            
        }

         
    }
     public void RestartScene()
{
    Scene thisScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(thisScene.name);
}

private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            if (Dead == false)
            {
                ded.Play();
            }
            Dead = true;
            
        }
        if (collision.gameObject.layer == 11 && CheckPointNum != 1)
        {
            CheckPointNum = 1;
        }
        if (collision.gameObject.layer == 12 && CheckPointNum != 2)
        {
            CheckPointNum = 2;
        }
        if (collision.gameObject.layer == 13 && CheckPointNum != 3)
        {
            CheckPointNum = 3;
        }
        if (collision.gameObject.layer == 14 && CheckPointNum != 4)
        {
            CheckPointNum = 4;
        }
        if (collision.gameObject.layer == 15 && CheckPointNum != 5)
        {
            CheckPointNum = 5;
        }

    }
}
