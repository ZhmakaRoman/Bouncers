using System;
using UnityEngine;



public class EnemyManager : MonoBehaviour
{

    [SerializeField] private GameObject _cylinderPrefab ;
    [SerializeField] private GameObject _cubePrefab ;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (CheckSameColor(_cylinderPrefab, _cubePrefab))
            {
                Destroy(_cylinderPrefab);
            }

        }
    }

    private bool CheckSameColor(GameObject element1, GameObject element2)
   {
       MeshRenderer renderer1 = element1.GetComponent<MeshRenderer>();
       MeshRenderer renderer2 = element2.GetComponent<MeshRenderer>();

       if (renderer1 != null && renderer2 != null)
       {
           if (renderer1.sharedMaterial.color == renderer2.sharedMaterial.color)
           {
               return true; 
           }
       }

       return false; 
   }
   
   
   
}
