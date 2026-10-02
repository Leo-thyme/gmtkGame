using UnityEngine;
using UnityEngine.SceneManagement;

public class Dzem_Collect_2 : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public CircleCollider2D colliderr;
    public PlayerMoveset playerMoveset;
    private float remaining_time = 5f;

    void Start()
    {
        spriteRenderer.enabled = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("isCollected", true);

            Speed_Up();

        }
    }

    public void AnimationEnd(string message)
    {
        if (message.Equals("CollectAnimationEnded"))
        {
            spriteRenderer.gameObject.SetActive(false);
        }
    }



    private void Speed_Up()
    {
        
        remaining_time += Time.deltaTime;

        if (remaining_time > 3f)
        {
            playerMoveset.speed = 5;

        }
        else
        {
            playerMoveset.speed = 10;
        }
    }

}
