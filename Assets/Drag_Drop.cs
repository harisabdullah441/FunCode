using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag_Drop : MonoBehaviour
{

    private Vector3 offset;
  //  [SerializeField] private bool dragging, box_trigger;
   
    private Vector3 intialPosition;
    private RaycastHit2D hit;
    private void Awake()
    {

    }
    private void Start()
    {
        intialPosition = transform.position;
    }

    private void Update()
    {

    }
    private void OnMouseDown()
    {
       Drag_Drop_Audio.GetInstance(). audioSource.PlayOneShot(Drag_Drop_Audio.GetInstance().pick_clip);
        offset = transform.position - GetMouseWorldPos();

    }
    private void OnMouseUp()
    {
        Drag_Drop_Audio.GetInstance().audioSource.PlayOneShot(Drag_Drop_Audio.GetInstance().drop_clip);

        transform.position = intialPosition;
        CheckingColorMatch();
    }


    private void OnMouseDrag()
    {

         hit = Physics2D.Raycast(transform.position, Vector2.zero);
       
     

        transform.position = GetMouseWorldPos() + offset;
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }


    private void CheckingColorMatch()
    {
        if (hit.collider != null)
        {
            if (transform.tag == hit.transform.tag)
            {
                hit.transform.parent.GetComponent<If_Else_Checker>().IfCheck();
            }
            else
            {
                hit.transform.parent.GetComponent<If_Else_Checker>().ElseCheck();

            }
        }
    }
}


