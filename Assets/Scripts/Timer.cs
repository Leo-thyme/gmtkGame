using TMPro;
using UnityEngine;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float remainingTime;
    public Animator animator;

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            

        }
        
     

            int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}",minutes, seconds);

        
    }

}
