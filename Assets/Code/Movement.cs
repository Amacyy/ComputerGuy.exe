using UnityEngine;
using UnityEngine.Events;

public class Movement : MonoBehaviour
{
	[SerializeField] private float speed;
	private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(3.681163f, 3.681163f, 3.681163f);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-3.681163f, 3.681163f, 3.681163f);

        if (Input.GetKey(KeyCode.Space) && grounded)
            jump();

        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);

    }

    private void jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
            grounded = true;
    }
}