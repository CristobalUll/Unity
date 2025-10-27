using UnityEngine;
using UnityEngine.EventSystems;

public class Collectible : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float collectTime = 2f;
    private float gazeTimer = 0f;
    private bool isGazedAt = false;
    private bool collected = false;

    private void Update()
    {
        if (isGazedAt && !collected)
        {
            gazeTimer += Time.deltaTime;
            if (gazeTimer >= collectTime)
            {
                collected = true;
                gameObject.SetActive(false); // Recolectado
                GameManager.instance.AddCollected(this);
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isGazedAt = true;
        gazeTimer = 0f;
        Debug.Log($"Mirando la gema {gameObject.name}");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isGazedAt = false;
        gazeTimer = 0f;
        Debug.Log($"Dejaste de mirar la gema {gameObject.name}");
    }
}
