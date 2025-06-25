using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalTrigger : MonoBehaviour
{
    public GameObject levelCompletePanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            levelCompletePanel.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
