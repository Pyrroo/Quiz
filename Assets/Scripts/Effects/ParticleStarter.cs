using UnityEngine;

public class ParticleStarter : MonoBehaviour
{
    [SerializeField] ParticleSystem particlePrefab;
    public void PlayParticles(Transform spawnPosition)
    {
        ParticleSystem particle = Instantiate(particlePrefab, spawnPosition.position, Quaternion.identity);
        particle.Play();
    }
}
