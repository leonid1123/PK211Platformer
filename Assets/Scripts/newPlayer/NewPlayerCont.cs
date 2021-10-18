using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerCont : MonoBehaviour
{
    private Rigidbody2D rb2;
    private Animator PlayerAnim;

    private float hMove = 0;
    private float speed = 3f;

    private bool toRight = true;


    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        PlayerAnim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (!PlayerAnim.GetCurrentAnimatorStateInfo(0).IsName("PlayerAttack1"))
        {
            hMove = Input.GetAxisRaw("Horizontal");
            PlayerAnim.SetFloat("moveSpeed", Mathf.Abs(hMove));
            Movement(hMove, speed);
        }
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerAnim.SetTrigger("atk1");
            rb2.velocity = new Vector2(0, 0);
        }
    }
    void Movement(float move, float spd)
    {
        rb2.velocity = new Vector2(move * spd, rb2.velocity.y);
        if (toRight && move < 0)
        {
            Flip();
        }
        else if (!toRight && move > 0)
        {
            Flip();
        }
    }
    void Flip()
    {
        toRight = !toRight;
        transform.Rotate(0, 180f, 0);
    }

}
