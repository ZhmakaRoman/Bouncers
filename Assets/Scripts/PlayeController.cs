using System;
using UnityEngine;

public class PlayeController : MonoBehaviour
{ 
   [SerializeField] private LayerMask _layerMask;
   [SerializeField] private float _sideForceValue = 100;
   private Rigidbody _rigidbody;
   private int _coint = 0;

   private Camera _camera;

   private void Start()
   { 
      _rigidbody = GetComponent<Rigidbody>();
       _camera = Camera.main;
   }

   private void Update()
   {
      var ray = _camera.ScreenPointToRay(Input.mousePosition);
      if (!Physics.Raycast(ray, out var hit,100f,_layerMask))
      {
         return;
      }

      if (Input.GetMouseButtonDown(0))
      {
         AddForce(hit.point);
      }
   }

   private void AddForce(Vector3 hitPoint)
   {
      var force = (hitPoint - _rigidbody.position)* _sideForceValue;
      _rigidbody.AddForce(force);
   }
}



