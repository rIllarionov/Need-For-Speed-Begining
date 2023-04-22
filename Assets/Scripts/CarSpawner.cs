using System;
using UnityEngine;
using UnityEngine.UI;


public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    private void Awake()
    {
        Instantiate(_prefab);
        var joints = GetComponents<SpringJoint>();
    }
}