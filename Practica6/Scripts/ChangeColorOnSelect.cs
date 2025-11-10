using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorOnSelect : MonoBehaviour
{
    private Renderer rend;
    private Color originalColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        var interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnSelectEnter);
        interactable.selectExited.AddListener(OnSelectExit);
    }

    void OnSelectEnter(SelectEnterEventArgs args)
    {
        rend.material.color = Color.red;
    }

    void OnSelectExit(SelectExitEventArgs args)
    {
        rend.material.color = originalColor;
    }
}
