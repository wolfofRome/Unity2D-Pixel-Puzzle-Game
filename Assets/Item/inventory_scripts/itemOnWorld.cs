using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class itemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    public GameObject VFX;
    public AudioSource holdAudio;

    public void Start()
    {
        holdAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        holdAudio.Play();
        if (other.gameObject.CompareTag("Player"))
        {
            // if (Input.GetKeyDown(KeyCode.Space))
            // {
 
            AddNewItem();
            Instantiate(VFX, transform.position, transform.rotation);
            Destroy(gameObject);
            
           // }
        }
    }

    public void AddNewItem()
    {
        if (!playerInventory.itemList.Contains(thisItem))
        {
            playerInventory.itemList.Add(thisItem);
            InventoryManager.CreateNewItem(thisItem);
        }
        else
        {
            thisItem.itemHeld += 1;
        }

        InventoryManager.RefreshItem();
    }
}
