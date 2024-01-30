using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    [SerializeField] private TMP_Text money;
    [SerializeField] private int currentMoney;
    // Start is called before the first frame update
    void Start()
    {
        money.text = currentMoney.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void AddMoney(int number)
    {
        currentMoney += number;
        money.text = currentMoney.ToString();
    }
}
