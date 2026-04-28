using UnityEngine;

public class MoveSpinIncrease : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.back * 4f * Time.deltaTime, Space.Self);
        transform.Rotate(Vector3.down, 150 * Time.deltaTime);
        transform.localScale += transform.lossyScale * 0.4f * Time.deltaTime;
    }
}
