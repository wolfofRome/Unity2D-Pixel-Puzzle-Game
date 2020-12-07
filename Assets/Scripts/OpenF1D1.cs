using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenF1D1 : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private bool InDoor=true;
    private bool isOpen;
    void Start()
    {
        anim=transform.parent.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)&&InDoor)
        //if(true)
        {
        	isOpen = !isOpen;
        	anim.SetBool("F1D1Open",isOpen);

        }
    }
    private void OntriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.CompareTag("Player"))
    	{
    		InDoor=true;
    	}
    }
}