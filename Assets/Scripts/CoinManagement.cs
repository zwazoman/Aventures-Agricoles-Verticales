using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManagement : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinText;
    public int nbCoin;

    public void Coin(int _number)
    {
        if (_number < -nbCoin) return;
        nbCoin += _number;
        _coinText.text = nbCoin.ToString();
    }
}
