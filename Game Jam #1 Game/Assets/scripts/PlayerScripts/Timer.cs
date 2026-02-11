using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class TimerManager : MonoBehaviour
{
    public float timeRemaining = 120f;
    public bool timerIsRunning = false;
    public TextMeshProUGUI TimerText; 

    void Start()
    {
        // Start the timer when the game begins
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                DisplayTime(timeRemaining); // Display 00:00 when finished
                // Trigger any end-of-timer actions here (e.g., game over)
                SceneManager.LoadScene(3);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // Ensure time is not negative for display purposes
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        // Calculate minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Format the time string to display minutes and seconds with leading zeros
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}