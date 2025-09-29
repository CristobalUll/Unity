using UnityEngine;

public class SceneReporter : MonoBehaviour
{
    void Start()
    {
        // Buscar todos los objetos de la escena sin orden (más rápido)
        GameObject[] allObjects = Object.FindObjectsByType<GameObject>(FindObjectsSortMode.None);

        foreach (GameObject obj in allObjects)
        {
            if (obj.tag != "Untagged")
            {
                Debug.Log($"Objeto: {obj.name} | Etiqueta: {obj.tag} | Posición: {obj.transform.position}");
            }
        }
    }
}
