using UnityEngine;
using UnityEngine.Animations;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public Timer timer;
    public bool BoosterActive;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    public void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        rb.linearVelocity = new Vector2(moveHorizontal, moveVertical) * speed;
        spriteRenderer.flipX = rb.linearVelocity.x < 0;


        if (moveHorizontal != 0)
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }


        if (moveVertical != 0 & rb.linearVelocity.y < 0)
        {
            animator.SetBool("isDown", true);
        }
        else
        {
            animator.SetBool("isDown", false);
        }


        if (moveVertical != 0 & rb.linearVelocity.y > 0)
        {
            animator.SetBool("isUp", true);
        }
        else
        {
            animator.SetBool("isUp", false);
        }

        if (timer.remainingTime <= 0)
        {
            animator.SetBool("isCought", true);
            animator.SetBool("isUp", false);
            animator.SetBool("isMoving", false);
            animator.SetBool("isDown", false);

            speed = 0;

        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            
            BoosterActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            
            BoosterActive = false;
        }
    }
}
