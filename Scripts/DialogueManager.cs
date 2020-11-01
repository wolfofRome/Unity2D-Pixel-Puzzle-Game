using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox; //显示或者隐藏整个对话窗口
    public Text dialogueText, nameText; //对话窗口的输出文字，对话者名字

    [TextArea(1, 3)] //使用特性TextArea，保证输入文字框不会显示成默认的一行
    public string[] dialogueLines; //声明一个数组：对话内容（多句话）
    [SerializeField] private float currentLine; //实时追踪当前对话窗口正在进行数组中的哪一行、哪一个元素
}
