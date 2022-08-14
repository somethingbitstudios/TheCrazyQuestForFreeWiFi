using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze_rotation : MonoBehaviour
{
    float lockpos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(lockpos, lockpos, lockpos);
    }
}
