using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += transform.lossyScale * _speed;
    }
}
