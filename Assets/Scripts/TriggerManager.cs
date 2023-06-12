using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TriggerManager : MonoBehaviour
{

   [SerializeField] private Renderer _renderer;
   [SerializeField] private GameObject[] _spherePrefabs;
  

   
   private void OnTriggerEnter(Collider other)
   {

      if (other.gameObject.CompareTag("Player"))
      {
         other.gameObject.GetComponent<Renderer>().sharedMaterial.color = _renderer.sharedMaterial.color;
         Destroy(gameObject);
         InstantiateRandomSphere();
      }
   
   }
   private void InstantiateRandomSphere()
   {
      
      var randomIndex = Random.Range(0, _spherePrefabs.Length);
      var randomPosition = new Vector3(Random.Range(-4, 4), 0.25f, Random.Range(-4, 4));
      Instantiate(_spherePrefabs[randomIndex], randomPosition, Quaternion.identity);
      
   }

  
}
