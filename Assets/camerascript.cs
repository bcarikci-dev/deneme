using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour
{
    public GameObject BackGround,character;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position=new Vector3(character.transform.position.x,character.transform.position.y,-10f);
        BackGround.transform.position=new Vector3(transform.position.x,0f,0f);
    }
}
