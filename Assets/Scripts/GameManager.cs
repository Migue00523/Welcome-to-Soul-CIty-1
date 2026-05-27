using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance { get; private set; }

    // Vehículo seleccionado
    public int VehiculoSeleccionado { get; private set; }

    // Contadores de almas
    private int almasNivel1 = 0;
    private int almasNivel2 = 0;

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

    // Guardar vehículo seleccionado
    public void SetVehiculoSeleccionado(int indice)
    {
        VehiculoSeleccionado = indice;
    }

    // Cambiar escena
    public void IniciarJuego(string cambiarEscena)
    {
        SceneManager.LoadScene(cambiarEscena);
    }

    // Salir del juego
    public void SalirJuego()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }

    // Recolectar almas
    public void RecolectarAlma(int nivel)
    {
        // NIVEL 1
        if (nivel == 1)
        {
            almasNivel1++;

            Debug.Log("Almas Nivel 1: " + almasNivel1);

            // Cuando recoge las 2 almas
            if (almasNivel1 >= 2)
            {
                Debug.Log("Nivel 1 completado");

                // Volver a la ciudad
                SceneManager.LoadScene("SoulCity");
            }
        }

        // NIVEL 2
        if (nivel == 2)
        {
            almasNivel2++;

            Debug.Log("Almas Nivel 2: " + almasNivel2);

            // Cuando recoge la última alma
            if (almasNivel2 >= 1)
            {
                Debug.Log("Juego completado");

                // Volver a la ciudad
                SceneManager.LoadScene("SoulCity");
            }
        }
    }
}