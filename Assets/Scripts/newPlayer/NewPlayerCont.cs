using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerCont : MonoBehaviour
{
    private Rigidbody2D rb2;
    private Animator PlayerAnim;
    private AnimatorStateInfo atkAllow;

    private float hMove = 0;
    private float speed = 3f;

    private bool toRight = true;

    private bool canAtk = true;



    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        PlayerAnim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        atkAllow = PlayerAnim.GetCurrentAnimatorStateInfo(0);
        if (!atkAllow.IsName("PlayerAttack1") && !atkAllow.IsName("PlayerCast"))
        {
            hMove = Input.GetAxisRaw("Horizontal");
            PlayerAnim.SetFloat("moveSpeed", Mathf.Abs(hMove));
            Movement(hMove, speed);
        }
        if (Input.GetButtonDown("Fire1") && canAtk)
        {
            canAtk = false;
            PlayerAnim.SetTrigger("atk1");
            rb2.velocity = new Vector2(0, 0); //потом тут будут косяки!!!
            Invoke("CanAttack",0.5f);
        }
        if (Input.GetButtonDown("Fire2") && canAtk)
        {
            canAtk = false;
            PlayerAnim.SetTrigger("cast");
            rb2.velocity = new Vector2(0, 0); //потом тут будут косяки!!!
            Invoke("CanAttack", 0.5f);
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
    void CanAttack()
    {
        canAtk = true;
    }
}
