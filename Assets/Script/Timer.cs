using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{

    private float totalTime = 600.0f; // 5 minutes in seconds
    private float elapsedTime = 0.0f;
    private bool isTimerRunning = false;
    [SerializeField] private TextMeshProUGUI timerText;
    // public Text timerText;



// Start is called before the first frame update
    void Start()
    {
        StartTimer();
    }
    void Update()
    {
        if (isTimerRunning)
        {
            totalTime -= Time.deltaTime;
            // Debug.Log("Timer: " + totalTime);
            if (totalTime <= 0f)
            {
                // Timer has reached 5 minutes
                Debug.Log("Timer finished!");
                isTimerRunning = false;
                elapsedTime = 0.0f; // Reset the timer
                StopTimer();
                       SceneManager.LoadScene(2);
            }

            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        float remainingTime = Mathf.Max(0, totalTime - elapsedTime);
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        string timerString = string.Format("{0:00}:{1:00}", minutes, seconds);
        // timerText.text = timerString;
        Debug.Log(timerString);
        timerText.text = timerString;
    }

    public void StartTimer()
    {
        isTimerRunning = true;
    }

    public void StopTimer()
    {
        isTimerRunning = false;
        elapsedTime = 0.0f; // Reset the timer
    }
    

    
}
