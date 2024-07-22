using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeCounter : MonoBehaviour
{
    public float countdown = 5f;

    public float time = 0.5f;

    public Text timeText;

    AudioSource audioSource;

    public AudioClip startsound;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        
        countdown -= Time.deltaTime;

        
        timeText.text = countdown.ToString("f1") + "•b";

        
        if (countdown <= 0)
        {

            if (countdown + time <= 0)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }
    }
}