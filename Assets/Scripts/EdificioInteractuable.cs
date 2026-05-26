using UnityEngine;

public class EdificioInteractable : MonoBehaviour
{
    [SerializeField] private string nombreEscena;
    [SerializeField] private float distanciaInteraccion = 5f;

    private Transform jugador;
    private bool jugadorCerca = false;

    private void Start()
    {
        // Busca el vehículo del jugador por tag
        GameObject obj = GameObject.FindWithTag("Player");
        if (obj != null)
            jugador = obj.transform;
    }

    private void Update()
    {
        if (jugador == null) return;

        float distancia = Vector3.Distance(transform.position, jugador.position);
        jugadorCerca = distancia <= distanciaInteraccion;

        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            GameManager.Instance.IniciarJuego(nombreEscena);
        }
    }

    // Muestra la zona de interacción en el editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaInteraccion);
    }
}