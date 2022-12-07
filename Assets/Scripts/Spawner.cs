using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _container;
    [SerializeField] private GameObject _trainTemplate;
    [SerializeField] private int _trainAmount;
    [SerializeField] private float _delayBetweenSpawn;

    private float _elapsedTime;

    private List<GameObject> _trainPool = new List<GameObject>();
    private void Start()
    {
        _elapsedTime = 9f;
        IntitializePool();
    }
    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime >= _delayBetweenSpawn)
        {
            if (TryGetTrain(out GameObject train))
            {
                _elapsedTime = 0;
                SetTrain(train);
            }
        }
    }
    private void IntitializePool()
    {
        for (int i = 0; i < _trainAmount; i++)
        {
            var train = Instantiate(_trainTemplate,_container.transform);
            train.SetActive(false);
            _trainPool.Add(train);
        }
    }
    private bool TryGetTrain(out GameObject result)
    {
        result = _trainPool.FirstOrDefault(t => t.activeSelf == false);
        return result != null;
    }
    private void SetTrain(GameObject result)
    {
        result.SetActive(true);
        result.transform.position = _container.transform.position;
        result.transform.rotation = _container.transform.rotation;
    }
}
