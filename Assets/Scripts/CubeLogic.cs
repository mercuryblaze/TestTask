using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    private Spawner _spawner;

    private float _lifetime = 0;
    private float _traveldDistance = 0;

    private void Start()
    {
        _spawner = GameObject.FindObjectOfType<Spawner>();
    }

    private void Update()
    {
        _lifetime += Time.deltaTime;
        _traveldDistance = _lifetime * _spawner._objectSpeed;

        if (_traveldDistance >= _spawner._killDistance)
            Destroy(gameObject);
    }
}