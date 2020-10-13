using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    Rigidbody2D a;
    // Start is called before the first frame update
    void Start()
    {
        a=GetComponent<Rigidbody2D>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if(col.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
            Debug.Log("anan");
        }
    }
}
