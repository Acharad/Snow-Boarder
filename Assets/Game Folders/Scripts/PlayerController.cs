using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game_Folders.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float torque = 1f;
        private Rigidbody2D _rb;
        private SurfaceEffector2D _surfaceEffector2D;
        [SerializeField] private float startSpeed;
        
        [SerializeField] private float moveSpeed;
        
    
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
            _surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
            moveSpeed = _surfaceEffector2D.speed;
            startSpeed = moveSpeed;
        }
    
        void Update()
        {
            RotatePlayer();
            RespondToBoost();
        }
        
        private void RotatePlayer()
        {
            // positive torque 
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                _rb.AddTorque(torque);
            }
            // negative torque
            else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                _rb.AddTorque(-torque);
            }
        }
        
        private void RespondToBoost()
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && Math.Abs(startSpeed - moveSpeed) == 0)
            {
                moveSpeed += 5f;
                _surfaceEffector2D.speed = moveSpeed;
            }
            else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S) && moveSpeed > startSpeed)
            {
                moveSpeed -= 5f;
                _surfaceEffector2D.speed = moveSpeed;
            }
        }
    }
}
