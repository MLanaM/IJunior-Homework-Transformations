using UnityEngine;

public class Movement : MonoBehaviour
{
    private void Update()
    {
        float speed = 4f;
        transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
    }
}