using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerCylinder : MonoBehaviour
{
  [SerializeField]
  private GameObject[] _cylinderPrefabs;

  private void Awake()
  {
    InstantiateRandomCylinder();
  }

  private void InstantiateRandomCylinder()
  {
    for (int i = 0; i < _cylinderPrefabs.Length; i++)
   {
     var randomPosition = new Vector3(Random.Range(-4, 4), 0.5f, Random.Range(-4, 4));
     Instantiate(_cylinderPrefabs[i], randomPosition, Quaternion.identity);
   }
  }
}
