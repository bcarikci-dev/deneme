using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mother : MonoBehaviour
{
    //Parameters
    public SpriteRenderer CharcterSprite;
    Rigidbody2D a;
    bool isground=true;
    public float speed;
    
    public Animator animator;
    void OnCollisionStay2D()
    {      
        isground=true;
        animator.SetBool("isJumping",false);
    }

    void OnCollisionExit2D()
    {
        isground=false;
        animator.SetBool("isJumping",true);
    }
    void Start()
    {
        a=GetComponent<Rigidbody2D>();
        
    }
     void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        
    }

   public void OnLanding()
    {
        animator.SetBool("isJumping",false);
    }

    void Update()
    {
        //Crouch Button Code
        if(Input.GetButtonDown("Crouch")){
            animator.SetBool("Crouch",true);
        }
        if(Input.GetButtonUp("Crouch")){
            animator.SetBool("Crouch",false);
        }

        //Run Button Code
        if(Input.GetButton("Horizontal"))
        {
            transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0f,0f);
            if(Input.GetAxis("Horizontal")>0)
            {
                CharcterSprite.flipX=false;
            }
            if(Input.GetAxis("Horizontal")<0)
            {
                CharcterSprite.flipX=true;
            }

        }

        //Jump Button Code
        if(Input.GetButtonDown("Jump")&&isground)
        {
            
            a.AddForce(new Vector2(0f,5f),ForceMode2D.Impulse);
            animator.SetBool("isJumping",true);
        }

        //Speed Calculate 
        animator.SetFloat("Speed",Mathf.Abs( Input.GetAxis("Horizontal")*speed));
        



        
    
    }
}
