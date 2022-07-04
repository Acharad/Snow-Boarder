using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
   [SerializeField] private ParticleSystem dustParticle;
   
   private void OnCollisionEnter2D(Collision2D col)
   {
      if (col.gameObject.CompareTag("Ground"))
      {
         dustParticle.Play();
      }
   }

   private void OnCollisionExit2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ground"))
      {
         dustParticle.Stop();
      }
   }
}
