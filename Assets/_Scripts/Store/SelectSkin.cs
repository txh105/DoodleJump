using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectSkin : MonoBehaviour
{
    [SerializeField] private Button[] skinBtn;
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
        PlayerPrefs.SetInt("skin_index",buttonIndex);
        SceneManager.LoadScene(1);
    }

}
