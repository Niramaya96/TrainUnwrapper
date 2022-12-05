using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private float _maxDistanceRay;
    [SerializeField] private Train _trainMover;
    [SerializeField] private LayerMask _layerMask;

    private bool _blocked;

    private void Update()
    {
        _blocked = Physics.Raycast(transform.position, Vector3.right,_maxDistanceRay);

        Debug.DrawRay(transform.position, Vector3.right, Color.white, _maxDistanceRay);
    }

    private void FixedUpdate()
    {
        if (_blocked)
        {
            return;
        }
        else
        {
            _trainMover.Move(Vector3.right);
        }
    }
}
