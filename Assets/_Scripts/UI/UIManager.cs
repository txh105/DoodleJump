using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public void StoreBtn()
    {
        SceneManager.LoadScene(2);
    }
    public void ScoresBtn()
    {
        SceneManager.LoadScene(3);
    }
    public void OptionsBtn()
    {
        SceneManager.LoadScene(4);
    }
}
