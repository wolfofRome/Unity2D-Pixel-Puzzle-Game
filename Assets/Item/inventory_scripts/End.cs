using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class End : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInventory;
    public GameObject VFX;
    public AudioSource holdAudio;
    public GameObject loadScreen;

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
 

            AsyncOperation operation = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 2);
            operation.allowSceneActivation = true;
           // }
        }
    }


}
