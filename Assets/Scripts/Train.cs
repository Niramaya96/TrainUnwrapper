using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Train : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rigidbody;
    private Vector3 _normal;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 direction)
    {
        Vector3 directionAlongSurface = Project(direction);
        Vector3 offset = directionAlongSurface * (_speed * Time.deltaTime);

        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    private Vector3 Project(Vector3 direction)
    {
        return direction - Vector3.Dot(direction, _normal) * _normal;
    }
    private void OnCollisionStay(Collision collision)
    {
        _normal = collision.contacts[0].normal;
    }
}
