using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out TrainMover train))
        {
            train.gameObject.SetActive(false);
        }
    }
}
