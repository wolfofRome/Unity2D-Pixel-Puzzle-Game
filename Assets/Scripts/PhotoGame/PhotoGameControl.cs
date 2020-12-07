using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoGameControl : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    [SerializeField] private Transform[] pictures;

    public GameObject photoPanel;
    public GameObject keyPanel;

    public static bool youWin;

    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isEntered = false;
            photoPanel.SetActive(false);
            keyPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.E))
        {
            photoPanel.SetActive(true);

            if (pictures[0].rotation.z == 0 &&
            pictures[1].rotation.z == 0 &&
            pictures[2].rotation.z == 0 &&
            pictures[3].rotation.z == 0 &&
            pictures[4].rotation.z == 0 &&
            pictures[5].rotation.z == 0 &&
            pictures[6].rotation.z == 0 &&
            pictures[7].rotation.z == 0 &&
            pictures[8].rotation.z == 0 &&
            pictures[9].rotation.z == 0 &&
            pictures[10].rotation.z == 0 &&
            pictures[11].rotation.z == 0)
            {
                youWin = true;
                photoPanel.SetActive(false);
                keyPanel.SetActive(true);
            }
        }
    }
}
