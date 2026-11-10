using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GolfBall : MonoBehaviour
{
    [Header("Configuración de Impacto")]
    [SerializeField] private float forceMultiplier = 1.8f;
    [SerializeField] private float minHitVelocity = 0.3f; // Ignora toques accidentales lentos
    [SerializeField] private LayerMask clubLayer;

    [Header("Efectos")]
    [SerializeField] private AudioSource hitAudioSource;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisión proviene del palo de golf
        if (((1 << collision.gameObject.layer) & clubLayer) != 0 || collision.gameObject.CompareTag("GolfClub"))
        {
            // Obtener la velocidad relativa del impacto
            Vector3 hitVelocity = collision.relativeVelocity;
            float speed = hitVelocity.magnitude;

            if (speed >= minHitVelocity)
            {
                // Dirección del impacto basada en el punto de contacto
                Vector3 hitDirection = -collision.contacts[0].normal;

                // Aplicar impulso físico
                rb.AddForce(hitDirection * speed * forceMultiplier, ForceMode.Impulse);

                // Sonido de impacto (opcional)
                if (hitAudioSource != null)
                {
                    hitAudioSource.pitch = Random.Range(0.9f, 1.1f);
                    hitAudioSource.Play();
                }
            }
        }
    }
}