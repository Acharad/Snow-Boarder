using UnityEngine;

namespace Game_Folders.Scripts
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float torque = 1f;
        private Rigidbody2D _rb;
    
        void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }
    
        void Update()
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
    }
}
