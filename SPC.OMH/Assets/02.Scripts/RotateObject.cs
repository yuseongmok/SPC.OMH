using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30.0f;

    void Update()
    {
        // ��ü�� y�� ������ ȸ����Ŵ
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
