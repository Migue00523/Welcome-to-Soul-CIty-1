using UnityEngine;
using TMPro;

public class CarSelectorController : MonoBehaviour
{
    [SerializeField] private string CambiarEscena = "SoulCity"; 
    [SerializeField] private GameObject[] vehiculos;
    [SerializeField] private TextMeshProUGUI nombreVehiculo;
    [SerializeField] private float velocidadRotacion = 30f;
    [SerializeField] private Transform puntoDisplay;
    [SerializeField] private float escalaVehiculo = 1f;

    private int indiceActual = 0;
    private GameObject vehiculoActivo;

    private void Start()
    {
        MostrarVehiculo(indiceActual);
    }

    private void Update()
    {
        if (vehiculoActivo != null)
            vehiculoActivo.transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime);
    }

    public void Siguiente()
    {
        indiceActual = (indiceActual + 1) % vehiculos.Length;
        MostrarVehiculo(indiceActual);
    }

    public void Anterior()
    {
        indiceActual = (indiceActual - 1 + vehiculos.Length) % vehiculos.Length;
        MostrarVehiculo(indiceActual);
    }

    public void Seleccionar()
    {
        GameManager.Instance.SetVehiculoSeleccionado(indiceActual);
        GameManager.Instance.IniciarJuego(CambiarEscena);

    }

     private void MostrarVehiculo(int indice)
    {
        if (vehiculoActivo != null)
            Destroy(vehiculoActivo);

        vehiculoActivo = Instantiate(
            vehiculos[indice],
            puntoDisplay.position,
            puntoDisplay.rotation
        );

        vehiculoActivo.transform.localScale = Vector3.one * escalaVehiculo;
        nombreVehiculo.text = vehiculos[indice].name;
    }
}  