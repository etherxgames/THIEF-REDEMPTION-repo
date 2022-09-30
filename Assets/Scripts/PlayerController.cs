using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float move;
    bool facingright = true;
    bool isGrounded;
    public Animator _animate;
    Rigidbody2D _rb;
    public float _playerSpeed = 35f;
    public float _jumpPower = 550f;
    public AudioSource hop;


    void Start()
    {

        _animate = GetComponent<Animator>();
        isGrounded = false;
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        _animate.SetFloat("Walk", System.Math.Abs(move));
        

        if (move > 0f && !facingright)
        {
            Flip();
        }
        else if (move < 0f && facingright)
        {
            Flip();
        }
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(new Vector2(0f, _jumpPower), ForceMode2D.Impulse);
            hop.Play();

        }
        if (_rb.velocity.y < 0f && !isGrounded)
        {
            _rb.gravityScale = 20f;
        }
        else _rb.gravityScale = 12f;
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            _rb.velocity = new Vector2(move * _playerSpeed, _rb.velocity.y);
        }
        else _rb.velocity = new Vector2(move * _playerSpeed / 1.5f, _rb.velocity.y);
    }
    void Flip()
    {
        facingright = !facingright;
        Vector2 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
}
