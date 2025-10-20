using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  private Renderer rend;

    void Start()
    {
        // Buscar el Renderer del escudo o de un hijo (por si el mesh está dentro)
        rend = GetComponentInChildren<Renderer>();

        if (rend == null)
        {
            Debug.LogWarning($"{name} no tiene Renderer asignado o en hijos.");
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        // Cuando cualquier objeto lo toque
        if (collision.gameObject.CompareTag("Type 1") || collision.gameObject.CompareTag("Type 2"))
        {
            if (rend != null)
            {
                // Generar color aleatorio
                Color randomColor = new Color(Random.value, Random.value, Random.value);
                rend.material.color = randomColor;

                Debug.Log($"{name} cambió de color al ser tocado por {collision.gameObject.name}");
            }
        }
    }
}
