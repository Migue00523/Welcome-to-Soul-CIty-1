using UnityEngine;

public class Alma1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Alma recogida");

            Destroy(gameObject);
        }
    }
}