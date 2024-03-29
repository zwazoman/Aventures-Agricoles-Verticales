using TMPro;
using UnityEngine;

public class CoinManagement : MonoBehaviour
{
    public static CoinManagement Instance;

    [SerializeField] private CoinUI _coinUI;
    public int NbCoin { get; private set; }

    private void Awake()
    {
        Instance = this; // singleton
    }

    public void Coin(int _number)
    {
        if (_number < -NbCoin) return;
        NbCoin += _number;
        _coinUI.ChangeCoinNb(NbCoin);
    }
}
