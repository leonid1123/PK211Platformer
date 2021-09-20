using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private bool jump = false;

    public Rigidbody2D rb2d;

    private float hMove;
    public float speed = 2f;
    public float jumpForce = 3f;
    private bool onGround = false;
    private bool toRight = true;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("lvl1");
        }

        hMove = Input.GetAxis("Horizontal"); 
        if (hMove<0 && toRight)
        {
            transform.Rotate(0f,180f,0f);
            toRight = false;
        }
        if (hMove>0 && !toRight)
        {
            transform.Rotate(0f, 180f, 0f);
            toRight = true;
        }
        rb2d.velocity = new Vector2(hMove*speed,rb2d.velocity.y);
        jump = Input.GetButton("Jump");
        if (jump && onGround)
        {
            rb2d.AddForce(new Vector2(0f,1f*jumpForce),ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        onGround = true;
        Debug.Log(collision.tag);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        onGround = false;
    }
}
