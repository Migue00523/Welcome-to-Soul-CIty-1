using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float altura = 5f;
    [SerializeField] private float distancia = 8f;
    [SerializeField] private float suavidad = 5f;

    private Transform objetivo;

    public void SetObjetivo(Transform nuevoObjetivo)
    {
        objetivo = nuevoObjetivo;
    }

    private void LateUpdate()
    {
        if (objetivo == null) return;

        Vector3 posicionDeseada = objetivo.position
            - objetivo.forward * distancia
            + Vector3.up * altura;

        transform.position = Vector3.Lerp( transform.position, posicionDeseada, suavidad * Time.deltaTime);

        transform.LookAt(objetivo);
    }
}