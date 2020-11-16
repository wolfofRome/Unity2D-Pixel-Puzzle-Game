using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToFloor01 : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    private void OnTiggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            isEntered = true;
            SceneManager.LoadScene("Floor01");
        }
    }
}
