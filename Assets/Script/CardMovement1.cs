using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement1 : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed2 = 10f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed2);
        }

       
    }
}
