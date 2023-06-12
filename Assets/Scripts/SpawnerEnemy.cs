using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] _spherePrefabs;
   
    
    private void Start()
    {
        InstantiateRandomSphere();
    }

  
    private void InstantiateRandomSphere()
    {
        
            var randomIndex = Random.Range(0, _spherePrefabs.Length);
            var randomPosition = new Vector3(Random.Range(-4, 4), 0.25f, Random.Range(-4, 4));
            Instantiate(_spherePrefabs[randomIndex], randomPosition, Quaternion.identity);
        
    }
    
}
