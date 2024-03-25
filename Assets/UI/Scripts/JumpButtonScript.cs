using UnityEngine.EventSystems;
using UnityEngine;

public class JumpButtonScript : MonoBehaviour, IPointerDownHandler
{
    public bool isPressed = false;
   
    public void OnPointerDown(PointerEventData eventData)
    {
         isPressed = true;
    }
}
