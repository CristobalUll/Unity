using UnityEngine;

public class SeleccionGuerrero : MonoBehaviour
{
    public static WarriorController guerreroSeleccionado;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                var w = hit.collider.GetComponent<WarriorController>();
                if (w != null)
                {
                    guerreroSeleccionado = w;
                    Debug.Log("Guerrero seleccionado: " + w.name);
                }
            }
        }
    }
}