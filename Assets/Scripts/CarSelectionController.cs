using UnityEngine;
using TMPro;

public class CarSelectorController : MonoBehaviour
{
    [SerializeField] private GameObject[] vehiculos;
    [SerializeField] private TextMeshProUGUI nombreVehiculo;
    [SerializeField] private string nombreEscenaJuego = "SoulCity";
    [SerializeField] private float velocidadRotacion = 30f;

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

    // Métodos públicos — los llaman los botones
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
        // Delega la lógica al Singleton
        GameManager.Instance.SetVehiculoSeleccionado(indiceActual);
        GameManager.Instance.IniciarJuego(nombreEscenaJuego);
    }

    // Método privado — lógica interna de la clase
    private void MostrarVehiculo(int indice)
    {
        if (vehiculoActivo != null)
            Destroy(vehiculoActivo);

        vehiculoActivo = Instantiate(vehiculos[indice], Vector3.zero, Quaternion.identity);
        nombreVehiculo.text = vehiculos[indice].name;
    }
}