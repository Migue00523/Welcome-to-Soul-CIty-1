using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float velocidad = 1f;
    [SerializeField] private float velocidadGiro = 1f;

    private void Update()
    {
        float avance = 0f;
        float giro = 0f;

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) avance = 0.5f;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) avance = -0.5f;
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) giro = -1;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) giro = 1f;

        transform.Translate(Vector3.forward * avance * velocidad * Time.deltaTime);
        transform.Rotate(Vector3.up * giro * velocidadGiro * Time.deltaTime);
    }
}