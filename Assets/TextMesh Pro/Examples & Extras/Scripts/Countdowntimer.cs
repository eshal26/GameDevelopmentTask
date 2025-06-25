using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Countdowntimer : MonoBehaviour
{
    public float timeLeft = 120f;
    public TextMeshProUGUI timerText;
    public GameObject levelFailPanel;

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeLeft / 60);
            int seconds = Mathf.FloorToInt(timeLeft % 60);
            timerText.text = $"{minutes:00}:{seconds:00}";
        }
        else
        {
            timeLeft = 0;
            levelFailPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

     public void RestartLevel()
    {
        Debug.Log("Restart clicked!");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
