using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonShoot : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }


    void Update()
    {

    }

}







