using System;
using UnityEngine;

public class Pipka : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0f;

    private void Awake()
    {
        Debug.Log($"Моя скорость {_speed}");
    }

    private void Update()
    {
        var position = transform.position;
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            position.z += step;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        
        else if (Input.GetKey(KeyCode.A))
        {
            position.x -= step;
        }
        
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += step;
        }
        
        transform.position = position;
    }
}