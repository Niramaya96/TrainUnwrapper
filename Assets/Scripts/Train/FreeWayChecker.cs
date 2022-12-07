using UnityEngine;

public class FreeWayChecker : MonoBehaviour
{
    [SerializeField] private float _maxDistanceRay;
    [SerializeField] private TrainMover _trainMover;

    private bool _blocked;

    private void Update()
    {
        _blocked = Physics.Raycast(transform.position, transform.forward,_maxDistanceRay);

        Debug.DrawRay(transform.position, transform.forward * _maxDistanceRay, Color.green);
    }

    private void FixedUpdate()
    {
        if (_blocked)
        {
            return;
        }
        else
        {
            _trainMover.Move(transform.forward);
        }
    }
}
