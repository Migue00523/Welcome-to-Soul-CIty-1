using UnityEngine;

public class Alma1 : MonoBehaviour
{
    [SerializeField] private int nivel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.RecolectarAlma(nivel);
            Destroy(gameObject);
        }
    }
}