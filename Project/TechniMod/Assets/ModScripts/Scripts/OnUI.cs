using UnityEngine.EventSystems;
using UnityEngine;

//Eventy pod UI 
//Elementu kt�rymi poruszamy "drag and drop"
//np. przedmioty w inventorze i przeci�ganie ich do/z plecaka
//Pe�na lista event�w: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html
public class OnUI : MonoBehaviour, IPointerClickHandler, IPointerMoveHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        //Wywo�any podczas klikni�cia w obiekt 
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        
    }
}
