using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    public void RestartLevel()
    {
        Debug.Log("Restart button was clicked!");
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
