using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : Singleton<UIController>
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private GameObject player;
    [SerializeField] private int currentScore;
    [SerializeField] private List<Sprite> skinList;
    public GameObject losePanel;
    // Start is called before the first frame update
    void Start()
    {
        int indexSkin = PlayerPrefs.GetInt("skin_index");
        player.GetComponent<SpriteRenderer>().sprite = skinList[indexSkin];
    }
    private void OnEnable()
    {
        Platform.OnScoreChanged += UpdateScore;
    }
    private void OnDisable()
    {
        Platform.OnScoreChanged -= UpdateScore;
    }
    void UpdateScore()
    {
        int score = Mathf.RoundToInt(player.transform.position.y);
        if (currentScore <= player.transform.position.y)
        {
            currentScore = score;
        }
        else
        {
            currentScore = Mathf.RoundToInt(player.transform.position.y);
        }
        scoreTxt.text = currentScore.ToString();
    }
}
