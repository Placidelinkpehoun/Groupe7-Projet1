using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public Transform player; // Référence du joueur
    public float activationDistance = 5f; // Distance d'activation

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // Permet de répéter le son
        audioSource.Stop(); // S'assurer que le son est arrêté au début
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        // Si le joueur est proche et que le son n'est pas déjà joué
        if (distance <= activationDistance && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        // Si le joueur s'éloigne et que le son est en train de jouer
        else if (distance > activationDistance && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
