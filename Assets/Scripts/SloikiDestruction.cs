using UnityEngine;

public class SloikiDestruction : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            spriteRenderer.gameObject.SetActive(false);

        }
    }

    private void Start()
    {
        spriteRenderer.enabled = true;
    }
    void Update()
    {
        
    }
}
