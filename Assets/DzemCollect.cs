using Unity.VisualScripting;
using UnityEngine;

public class DzemCollect : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public CircleCollider2D colliderr;

    void Start()
    {
        spriteRenderer.enabled = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("isCollected", true);
            
        }
    }

   
    public void AnimationEnd(string message)
    {
        if (message.Equals("CollectAnimationEnded"))
        {
            spriteRenderer.gameObject.SetActive(false);
        }
    }

}

