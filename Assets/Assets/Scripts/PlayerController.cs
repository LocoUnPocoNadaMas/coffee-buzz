using System;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        [SerializeField] private Transform orientation;
        
        private Rigidbody _rg;
        private float _horizontal;
        private float _vertical;
        private Vector3 _moveDirection;
        
        public event Action<int> OnChangeCameraPosition;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _rg = GetComponent<Rigidbody>();
            _rg.freezeRotation = true;
        }

        // Update is called once per frame
        void Update()
        {
            Inputs();
        }

        private void FixedUpdate()
        {
            Moving();
        }

        private void Inputs()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                OnChangeCameraPosition?.Invoke(1);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                OnChangeCameraPosition?.Invoke(2);
            }
            _horizontal = Input.GetAxisRaw("Horizontal");
            _vertical = Input.GetAxisRaw("Vertical");
        }

        private void Moving()
        {
            _moveDirection = orientation.forward * _vertical + orientation.right * _horizontal;
            _rg.AddForce(_moveDirection.normalized * (moveSpeed * 100f * Time.deltaTime),  ForceMode.Force);
            _rg.transform.Rotate(Vector3.up, _horizontal, Space.Self);
        }
    }

}
