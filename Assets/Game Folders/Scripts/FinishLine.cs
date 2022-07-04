using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;


namespace Game_Folders.Scripts
{
    public class FinishLine : MonoBehaviour
    {
        [SerializeField] private float waitTime = 0.2f;
        [SerializeField] private ParticleSystem _particleSystem;
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                _particleSystem.Play();
                Invoke(nameof(ReloadScene), waitTime);
            }
        }

        void ReloadScene()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}