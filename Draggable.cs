using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

    Vector3 mousePositionOffset;
    
    
    private Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }



    private void OnMouseDown()
    {

        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();

        
    }
    private void OnMouseDrag()
    {
        this.gameObject.transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
    private void OnMouseUp()
    {
        this.gameObject.transform.GetComponent<Rigidbody>().useGravity = true;
        this.enabled = false;
    }

}
