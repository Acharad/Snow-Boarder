using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game_Folders.Scripts
{
    public class CrashDetector : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Ground"))
            {
                Debug.Log("You died!");
            }
        }
    }
}