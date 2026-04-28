using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.back * 0.1f;
    }
}