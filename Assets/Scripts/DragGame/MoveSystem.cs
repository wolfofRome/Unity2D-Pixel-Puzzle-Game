using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSystem : MonoBehaviour
{
    //public GameObject correctForm;
    public GameObject potion;
    public GameObject potionBlack;

    private bool moving;
    private bool finish;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;

    void Start()
    {
        resetPosition = potion.transform.localPosition;
    }

    void Update()
    {
        if(finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                potion.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, potion.gameObject.transform.localPosition.z);
            }
        }
        
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - potion.transform.localPosition.x;
            startPosY = mousePos.y - potion.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        float Distance = Vector3.Distance(potion.transform.position, potionBlack.transform.position);

        if (Distance < 1)
        {
            potion.transform.position = potionBlack.transform.position;
            finish = true;

            GameObject.Find("PointHandler").GetComponent<WinScript>().AddPoints();
        }
        else
        {
            potion.transform.position = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
}
