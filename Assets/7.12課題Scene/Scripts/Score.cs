using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text ScoreText = default;

     void Start()
    {
        Debug.Log("���Ȃ��̃X�R�A��" + "_score" + "�ł��B");
    }
}
