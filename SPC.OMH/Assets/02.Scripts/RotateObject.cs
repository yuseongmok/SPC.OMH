using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        // 물체를 y축 주위로 회전시킴
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
