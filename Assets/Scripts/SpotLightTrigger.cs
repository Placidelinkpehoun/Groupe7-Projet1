using UnityEngine;

public class SpotLightTrigger : MonoBehaviour
{
    public Transform player; // Référence du joueur
    public float activationDistance = 5f; // Distance d'activation

    private Light spotlight;

    void Start()
    {
        spotlight = GetComponent<Light>();
        spotlight.enabled = false; // Éteindre la lumière au début
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        // Allumer si le joueur est proche, sinon éteindre
        if (distance <= activationDistance)
        {
            spotlight.enabled = true;
            activationDistance = distance;
        }

    }
}
