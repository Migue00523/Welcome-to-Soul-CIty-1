using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Singleton
    public static GameManager Instance { get; private set; }

    // Estado global del juego
    public int VehiculoSeleccionado { get; private set; }


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

    public void IniciarJuego(string SelectionCar)
    {
        SceneManager.LoadScene(SelectionCar );
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}