using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private string nombreEscenaJuego = "SelectionCar";

    public void OnBotonJugar()
    {
        GameManager.Instance.IniciarJuego(nombreEscenaJuego);
    }

    public void OnBotonSalir()
    {
        GameManager.Instance.SalirJuego();
    }
}