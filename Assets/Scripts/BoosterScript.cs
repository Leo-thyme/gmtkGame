
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class BoosterScript : MonoBehaviour
{
    public Animator animator;
    public UnityEngine.UI.Image image;
    float TimerBooster = 0;
    public float boosterTimer = 0f;

    public PlayerMoveset playerMoveset;


    private void Awake()
    {
        image.enabled = false;
        animator.SetBool("End of animation", true);
    }

    void Update()
    {
       

        if (playerMoveset.BoosterActive == true)
        {
            
            image.enabled = true;

            boosterTimer += Time.deltaTime;
            animator.SetBool("End of animation", false);

            if (boosterTimer >= 9f)
            {
                image.enabled = false;
                animator.SetBool("End of animation", true);
                animator.speed = 1f;
                playerMoveset.BoosterActive = false;
            }
            else if (boosterTimer >= 6f)
            {

                animator.speed = 2f; 
            }
            else if (boosterTimer >= 3f)
            {

                animator.speed = 3f;
            }
        }
        
        
    }


  
}
