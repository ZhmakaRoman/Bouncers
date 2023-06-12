using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCube : MonoBehaviour
{
  [SerializeField] private GameObject _cubePrefab;
  
  private void Awake()
  {
    InstantiateRandomCube();
  }


  public void InstantiateRandomCube()
  {
    Instantiate(_cubePrefab);
  }
}
