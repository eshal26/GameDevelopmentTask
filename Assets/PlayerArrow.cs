using UnityEngine;

public class PlayerArrow : MonoBehaviour
{
    public Transform destination;

    void Update()
    {
        Vector3 direction = destination.position - transform.position;
        direction.y = 0; // ignore vertical rotation
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
