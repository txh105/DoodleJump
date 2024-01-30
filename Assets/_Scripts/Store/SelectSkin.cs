using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Security.Cryptography;

public class SelectSkin : MonoBehaviour
{
    [SerializeField] private Button[] skinBtn;
    [SerializeField] private string[] nameSkin;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < skinBtn.Length; i++)
        {
            int buttonIndex = i;
            skinBtn[i].onClick.AddListener(() => ClickHandler(buttonIndex));
        }
    }
    void ClickHandler(int buttonIndex)
    {
        PlayerPrefs.SetInt("skin_index", buttonIndex);
        //SceneManager.LoadScene(1);
    }
}