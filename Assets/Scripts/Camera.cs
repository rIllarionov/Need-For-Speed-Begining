using System;
using UnityEngine;
using UnityEngine.Serialization;

public class Camera : MonoBehaviour
{
    private Pipka _car;

    [SerializeField]
    private Vector3 _camera;

    private void Start()
    {
        _car = FindObjectOfType<Pipka>();
    }

    private void LateUpdate()
    {
        transform.position = _car.transform.position+_camera;
    }
}