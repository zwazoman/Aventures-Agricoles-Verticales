using TMPro;
using UnityEngine;

public class CoinManagement : MonoBehaviour
{
    public static CoinManagement instance;
    [SerializeField] private TMP_Text _coinText;
    public int nbCoin;

    private void Awake()
    {
        instance = this; // singleton
    }

    public void Coin(int _number)
    {
        if (_number < -nbCoin) return;
        nbCoin += _number;
        _coinText.text = nbCoin.ToString();
    }
}
