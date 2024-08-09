using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    [SerializeField] int _maxscore = 10;
    void Update()
    {
        //if (_score > _maxscore)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
