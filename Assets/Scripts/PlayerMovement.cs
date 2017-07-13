using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    [HideInInspector]
    public bool facingRight = true;
    [HideInInspector]
    public bool jump = false;
    public float Speed = 365f;
    
    public float jumpForce = 4.0f;
    public Transform groundCheck;


    private bool grounded = false;
    private Animator anim;
    private Rigidbody2D rb2d;


    // Use this for initialization
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        if (grounded)
        {
            jump = false;
        }
        
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            Debug.Log("Jump");
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jump = true;
        }

        float hSpeed = Input.GetAxis("Horizontal");

        if (hSpeed < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(hSpeed > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        rb2d.velocity = new Vector2(hSpeed * Speed, rb2d.velocity.y);
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}