using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game_Folders.Scripts
{
    public class CrashDetector : MonoBehaviour
    {
        [SerializeField] private float waitTime = 0.5f;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Ground"))
            {
                var particleSys = GetComponentInChildren<ParticleSystem>();
                particleSys.Play();
                Invoke(nameof(ReloadScene), waitTime);
            }
        }
        
        void ReloadScene()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}