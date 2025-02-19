using UnityEngine;

public class GazeAudioTrigger : MonoBehaviour
{
    public AudioSource audioSource; // Référence à l'AudioSource

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        if (audioSource != null)
        {
            audioSource.playOnAwake = false; // Empêche l'audio de jouer au démarrage
        }
    }

    // Méthode appelée lorsque le pointeur regarde l'objet
    public void OnPointerEnter()
    {
        if (audioSource != null && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    // Méthode appelée lorsque le pointeur quitte l'objet
    public void OnPointerExit()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }
}
