using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinNb;

    public void ChangeCoinNb(int _nbCoin)
    {
        _coinNb.text = _nbCoin.ToString();
    }
}
