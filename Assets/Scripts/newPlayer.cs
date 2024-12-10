using System.Collections;
using TMPro;
using UnityEngine;

public class newPlayer : MonoBehaviour
{

    private float moveforce = 10f;
    private float jumforce = 11f;

    private Rigidbody2D mybody;
    private SpriteRenderer spriteRenderer;
    private Animator anim;

    private bool isGrounded = true;

    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        jump();

    }
    //private void LateUpdate()
    //{
    //    jump();
    //}

    void move()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0) * moveforce * Time.deltaTime;
            anim.SetBool("walk", true);
            spriteRenderer.flipX = false;
            Debug.Log("Moving right");

        }else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * moveforce * Time.deltaTime;
            //mybody.AddForce(new Vector2(-1, 0) * jumforce, ForceMode2D.Force);
            anim.SetBool("walk", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

    void jump()
    {
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && isGrounded == true)
        {
            mybody.linearVelocity = new Vector2(mybody.linearVelocityX, jumforce); // Set velocity, don't add to it
            isGrounded = false;
        }
    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") && isGrounded == false)
        {
            isGrounded = true;
            Debug.Log("We landed on ground");
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            FindFirstObjectByType<gamePlayManager>().gameOver();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("count"))
        {
            score scoreScript = FindFirstObjectByType<score>();
            scoreScript.scoreIncrease();

        }
    }

    


}

    


