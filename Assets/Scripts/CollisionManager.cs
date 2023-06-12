using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{

    [SerializeField] private SpawnerCube _spawnerCube;
    [SerializeField] private float _spawnerTime = 1;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(AppearanceTimeCube());
        }
    }

    private IEnumerator AppearanceTimeCube()
    {
             yield return new WaitForSeconds(_spawnerTime); 
            _spawnerCube.InstantiateRandomCube();
            
    }

}
