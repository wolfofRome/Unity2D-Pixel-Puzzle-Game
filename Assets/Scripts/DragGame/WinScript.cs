<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    private int pointsToWin;
    private int currentPoints;
    public GameObject dragPanel;
    public GameObject keyPanel;

    public static bool youWin;

    void Start()
    {
        youWin = false;
        pointsToWin = dragPanel.transform.childCount;
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
            dragPanel.SetActive(false);
            keyPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.E))
        {
            dragPanel.SetActive(true);

            if (currentPoints >= pointsToWin)
            {
                youWin = true;
                dragPanel.SetActive(false);
                keyPanel.SetActive(true);
            }
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    private int pointsToWin;
    private int currentPoints;
    public GameObject dragPanel;

    public static bool youWin;

    void Start()
    {
        youWin = false;
        pointsToWin = dragPanel.transform.childCount;
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
            dragPanel.SetActive(false);
        }
    }

    void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.E))
        {
            dragPanel.SetActive(true);

            if (currentPoints >= pointsToWin)
            {
                youWin = true;
                dragPanel.SetActive(false);
            }
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
>>>>>>> 3f3a041b3d2598dca96c62102c8741e440599627
