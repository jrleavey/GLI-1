using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPointLocation;
    [SerializeField]
    private Transform finishPointLocation;
    [SerializeField]
    private GameObject _targetContainer;
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private int _targetsSpawned = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void Spawner()
    {
        GameObject newEnemy = Instantiate(_target, spawnPointLocation.transform.position, spawnPointLocation.transform.rotation);
        _targetsSpawned++;
        newEnemy.transform.parent = _targetContainer.transform;
    }
}
