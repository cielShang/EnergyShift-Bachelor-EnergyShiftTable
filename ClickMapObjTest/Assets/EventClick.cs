using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler 
{
    public Material newMaterial; // Das Material, das angewendet werden soll

    private Material originalMaterial; // Das ursprüngliche Material des GameObjects

    private Renderer rend;

    private void Start()
    {
        // Speichere das ursprüngliche Material des GameObjects
        rend = GetComponent<Renderer>();
        originalMaterial = rend.material;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Ändere das Material des GameObjects, wenn der Mauszeiger darüber bewegt wird
        rend.material = newMaterial;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Setze das ursprüngliche Material des GameObjects zurück, wenn der Mauszeiger das GameObject verlässt
        rend.material = originalMaterial;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
