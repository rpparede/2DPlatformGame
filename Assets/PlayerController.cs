using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.A)){
        rb.velocity = new Vector2(-5, rb.velocity.y);
        transform.localScale = new Vector2(-1, 1);
        anim.SetBool("running", true);
      } else if(Input.GetKey(KeyCode.D)){
        rb.velocity = new Vector2(5, rb.velocity.y);
        transform.localScale = new Vector2(1, 1);
        anim.SetBool("running", true);
      } else {
        anim.SetBool("running", false);
      }

      if(Input.GetKeyDown(KeyCode.Space)){
        rb.velocity = new Vector2(rb.velocity.x, 10f);
      }
    }

}
