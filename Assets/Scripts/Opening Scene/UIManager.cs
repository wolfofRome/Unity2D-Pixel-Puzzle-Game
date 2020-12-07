using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject story2;

    public GameObject dialogueBox1; //显示or隐藏整个对话窗口

    public GameObject dialogueBox2;

    private void Start()
    {
        dialogueBox1.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueBox1.SetActive(false);
            story2.SetActive(true);
            dialogueBox2.SetActive(true);
        }


    }
}
