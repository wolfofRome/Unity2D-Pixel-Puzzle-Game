using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenTheDoor : MonoBehaviour
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
        if(Input.GetKeyDown(KeyCode.C)&&InDoor)
        //if(true)
        {
        	isOpen = !isOpen;
        	anim.SetBool("Open",isOpen);

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
