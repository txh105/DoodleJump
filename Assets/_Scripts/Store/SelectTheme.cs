using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectTheme : MonoBehaviour
{
    [SerializeField] private List<GameObject> themeList;
    // Start is called before the first frame update
    void Start()
    {
        int indexSelect = PlayerPrefs.GetInt("theme_index");
        themeList[indexSelect].SetActive(true);
        for (int i = 0; i < themeList.Count; i++)
        {
            if (i != indexSelect)
            {
                themeList[i].SetActive(false);
            }
        }
    }
}
