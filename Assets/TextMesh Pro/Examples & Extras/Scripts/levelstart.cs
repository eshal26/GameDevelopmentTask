using UnityEngine;
using TMPro;

public class levelstart : MonoBehaviour
{
    public TextMeshProUGUI startText;

    void Start()
    {
        startText.gameObject.SetActive(true);
        Invoke("HideMessage", 3f); // hide after 3 seconds
    }

    void HideMessage()
    {
        startText.gameObject.SetActive(false);
    }
}
