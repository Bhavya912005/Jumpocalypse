using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public GameObject CoinDisplay;
    public static int CoinCount;
    public int InternalCoin;


    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Coins: " + CoinCount;

    }
}






