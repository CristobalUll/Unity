using UnityEngine;
using UnityEngine.EventSystems;

public class Collector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float gazeTime = 2f;
    public float attractSpeed = 5f;

    private float gazeTimer = 0f;
    private bool isGazedAt = false;

    private void Update()
    {
        if (isGazedAt)
        {
            gazeTimer += Time.deltaTime;
            if (gazeTimer >= gazeTime)
            {
                AttractCollectibles();
                gazeTimer = 0f;
            }
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        isGazedAt = true;
        gazeTimer = 0f;
        Debug.Log("Mirando el colector");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isGazedAt = false;
        gazeTimer = 0f;
        Debug.Log("Dejaste de mirar el colector");
    }

    private void AttractCollectibles()
    {
        foreach (var c in GameManager.instance.collected)
        {
            if (c != null)
            {
                c.transform.position = Vector3.MoveTowards(
                    c.transform.position,
                    transform.position,
                    attractSpeed * Time.deltaTime
                );
            }
        }
    }
}
