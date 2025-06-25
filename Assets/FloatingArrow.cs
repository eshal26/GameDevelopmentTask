using UnityEngine;

public class FloatingArrow : MonoBehaviour
{
    public float floatSpeed = 2f;     // How fast it floats
    public float floatHeight = 0.5f;  // How far it moves up/down
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition; // Use localPosition because it's a child
    }

    void Update()
    {
        float newY = Mathf.Sin(Time.time * floatSpeed) * floatHeight;
        transform.localPosition = startPos + new Vector3(0, newY, 0);
    }
}
