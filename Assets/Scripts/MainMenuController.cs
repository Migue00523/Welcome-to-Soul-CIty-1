using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private string CambiarEscena = "SelectionCar";

    public void OnBotonJugar()
    {
        GameManager.Instance.IniciarJuego(CambiarEscena);
    }

    public void OnBotonSalir()
    {
        GameManager.Instance.SalirJuego();
    }

 
}
