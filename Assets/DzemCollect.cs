using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DzemCollect : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public CircleCollider2D colliderr;
    public PlayerMoveset playerMoveset;

    void Start()
    {
        spriteRenderer.enabled = true;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("isCollected", true);
            playerMoveset.BoosterActive = true;
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

