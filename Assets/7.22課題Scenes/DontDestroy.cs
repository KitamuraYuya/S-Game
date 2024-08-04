using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    [SerializeField] string _textName = "NameText";
    [SerializeField] string _name = "AI";
    bool _startName = false;
    void Start()
    {
        if (FindObjectsOfType<DontDestroy>().Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            Message();
            _startName = true; 
        }
    }

    public void SetName(InputField input)
    {
        _name = input.text;
    }

    private void OnLevelWasLoaded(int level)
    {
        if (_startName) Message();
    }

    void Message()
    {
        GameObject tof = GameObject.Find(_textName);
        Text text = tof?.GetComponent<Text>();

        if (text)
        {
            text.text = $"ÉSÅ[ÉãÇñ⁄éwÇµÇƒÇ™ÇÒÇŒÇÍ<color=blue>{_name}</color>!";
            Debug.Log(text.text);
        }
    }
}
