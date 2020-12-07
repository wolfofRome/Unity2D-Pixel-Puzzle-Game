using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private bool isEntered;

    public GameObject dialogueBox; //显示or隐藏整个对话窗口
    public Text dialogueText; //输出文字

    [TextArea(1, 4)] //使用特性TextArea，保证输入文本框不会显示默认的一行，因为一行可能文字太多 难以阅读
    public string dialogue;
    //public string[] dialogueLines; //用数组表示对话内容（多句话）
    //[SerializeField] private int currentLine; //实时追踪当前对话窗口正在进行数组中哪一行、哪一个元素的文字内容输出


    private void Start()
    {
        //dialogueText.text = dialogueLines[currentLine];
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
            dialogueBox.SetActive(false);
        }
    }

    private void Update()
    {
        if (isEntered && Input.GetKeyDown(KeyCode.Space))
        {
            if (dialogueBox.activeInHierarchy)
            {
                dialogueBox.SetActive(false);
            }
            else
            {
                dialogueBox.SetActive(true);
                dialogueText.text = dialogue;
            }           
        }


    }
}
