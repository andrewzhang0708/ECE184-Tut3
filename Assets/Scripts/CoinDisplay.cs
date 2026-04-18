using UnityEngine;
using TMPro;
using System;

public class CoinDisplay : MonoBehaviour
{
    TMP_Text tmptext;
    private void Awake()
    {
        tmptext = GetComponent<TMP_Text>();
    }
    private void Start()
    {
        GameManager.instance.OnCollectCoins += UpdateCoinDisplay;
    }

    private void OnDestroy()
    {
        GameManager.instance.OnCollectCoins -= UpdateCoinDisplay;
    }

    private void UpdateCoinDisplay(object sender, GameManager.OnCollectCoinsEventArgs e)
    {
        // GetComponent<TMPro.TextMeshProUGUI>().text = e.value.ToString();
        tmptext.text = e.value.ToString();
    }
}
