using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    private Spawner _spawner;

    private void Start()
    {
        _spawner = GameObject.FindObjectOfType<Spawner>();
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _spawner._objectSpeed * Time.deltaTime);
    }
}