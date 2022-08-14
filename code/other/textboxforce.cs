using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textboxforce : MonoBehaviour
{
    public bool destroywhenactivated;
    public TextAsset thetext;
    public int startline;
    public int endline;
    public int filelenght;
    public textloader thetextbox;
    public bool canE;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        thetextbox = FindObjectOfType<textloader>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canE && thetextbox.cando == true)
        {

            thetextbox.ReloadScript(thetext);
            thetextbox.currentline = startline;
            thetextbox.endline = endline;
            if (filelenght > endline)
            {
                startline += 1;
                endline += 1;
            }

            thetextbox.Enabletxt();

            if (destroywhenactivated)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        sp.enabled = true;
        canE = true;

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        sp.enabled = false;
        canE = false;

    }
}
