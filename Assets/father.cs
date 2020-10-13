using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class father : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
