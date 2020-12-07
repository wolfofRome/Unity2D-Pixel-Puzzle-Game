<<<<<<< HEAD
﻿using UnityEngine;

public class EnterDialog : MonoBehaviour
{
    public GameObject enterDialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            enterDialog.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enterDialog.SetActive(false);
        }
    }
}
=======
﻿using UnityEngine;

public class EnterDialog : MonoBehaviour
{
    public GameObject enterDialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            enterDialog.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            enterDialog.SetActive(false);
        }
    }
}
>>>>>>> 3f3a041b3d2598dca96c62102c8741e440599627
