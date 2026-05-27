using UnityEngine;

public class Alma1 : MonoBehaviour
{
    [SerializeField] private int nivel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            Debug.Log("Alma recogida");

            GameManager.Instance.RecolectarAlma(nivel);

            Destroy(gameObject);
        }
    }
}