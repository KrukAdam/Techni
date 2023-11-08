using UnityEngine.EventSystems;
using UnityEngine;
using TMPro;

//Eventy pod UI 
//Elementu którymi poruszamy "drag and drop"
//np. przedmioty w inventorze i przeci¹ganie ich do/z plecaka
//Pe³na lista eventów: https://docs.unity3d.com/Packages/com.unity.ugui@1.0/api/UnityEngine.EventSystems.html
public class OnUI : MonoBehaviour, IPointerClickHandler, IPointerMoveHandler
{
    TMP_Text text; 

    public void OnPointerClick(PointerEventData eventData)
    {
        //Wywo³any podczas klikniêcia w obiekt 
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        
    }
}
