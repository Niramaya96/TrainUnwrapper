using UnityEngine;

public class Platform : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float rotateSpeed = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.A))
        {
            Rotate(rotateSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rotate(rotateSpeed);
        }
    }

    private void Rotate(float rotateSpeed)
    {
        Vector3 resEuler = transform.eulerAngles + new Vector3(0f,rotateSpeed,0f);

        _rigidbody.MoveRotation(Quaternion.Euler(resEuler));
    }
}
