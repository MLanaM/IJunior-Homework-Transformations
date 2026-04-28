using UnityEngine;

public class Size : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += transform.lossyScale * _speed * Time.deltaTime;
    }
}
