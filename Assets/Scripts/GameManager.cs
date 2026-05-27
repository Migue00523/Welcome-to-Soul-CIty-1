using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance { get; private set; }

    // Estado global del juego
    public int VehiculoSeleccionado { get; private set; }

    // Contador de almas
    private int almasRecolectadas = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetVehiculoSeleccionado(int indice)
    {
        VehiculoSeleccionado = indice;
    }

    public void IniciarJuego(string CambiarEscena)
    {
        SceneManager.LoadScene(CambiarEscena);
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }

    public void RecolectarAlma(int nivel)
    {
        almasRecolectadas++;

        Debug.Log("Almas recolectadas: " + almasRecolectadas);

        if (nivel == 1 && almasRecolectadas == 2)
        {
            Debug.Log("Primer edificio completado");
        }

        if (nivel == 2 && almasRecolectadas == 3)
        {
            Debug.Log("¡Juego completado!");
        }
    }
}