using System.Collections;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            StartCoroutine(OpenBarrier());
        }
    }

    private IEnumerator OpenBarrier()
    {
        transform.Translate(Vector3.up);
        yield return new WaitForSeconds(3f);
        transform.Translate(Vector3.down);
    }
}
