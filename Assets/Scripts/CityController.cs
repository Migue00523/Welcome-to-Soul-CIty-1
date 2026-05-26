using UnityEngine;

public class CityController : MonoBehaviour
{
    [SerializeField] private GameObject[] vehiculos;
    [SerializeField] private Transform puntoSpawn;
    [SerializeField] private float escalaVehiculo = 0.2f;

    private GameObject vehiculoActivo;

    private void Start()
    {
        SpawnVehiculo();
    }

    private void SpawnVehiculo()
    {
        int indice = GameManager.Instance.VehiculoSeleccionado;
        vehiculoActivo = Instantiate( vehiculos[indice], puntoSpawn.position, puntoSpawn.rotation);
        vehiculoActivo.transform.localScale = Vector3.one * escalaVehiculo;

        CameraFollow camara = Camera.main.GetComponent<CameraFollow>();
        if (camara != null)
        {
            camara.SetObjetivo(vehiculoActivo.transform);
        }
    }
}