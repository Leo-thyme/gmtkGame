
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
    bool boosterActive = false;

    NewMonoBehaviourScript playerMoveset;
    public GameObject player;

    private void Awake()
    {
        playerMoveset = player.GetComponent<NewMonoBehaviourScript>();
        image.enabled = false;
        animator.SetBool("End of animation", true);
    }

    void Update()
    {
        if (playerMoveset.BoosterActive == true)
        {
            boosterActive = true;
            boosterTimer = 0f;

            image.enabled = true;
            animator.speed = 1f;
        }


        //if (dzemik.GetBool("isCollected") && !boosterActive)
        //{
          //  boosterActive = true;
            //boosterTimer = 0f;

           // image.enabled = true;
           // animator.speed = 1f;
       // }

        if (boosterActive == true)
        {
            
            boosterTimer += Time.deltaTime;
            animator.SetBool("End of animation", false);

            if (boosterTimer >= 9f)
            {
               
                boosterActive = false;

                image.enabled = false;
                animator.speed = 1f; // Return to normal speed
            }
            else if (boosterTimer >= 6f)
            {

                animator.speed = 3f; 
            }
            else if (boosterTimer >= 3f)
            {

                animator.speed = 2f;
            }
        }
        else
        {
            image.enabled = false;
            animator.SetBool("End of animation", true);
           
        }

        
    }
    
}
