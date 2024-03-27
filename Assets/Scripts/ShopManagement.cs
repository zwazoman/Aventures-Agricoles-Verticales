using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManagement : MonoBehaviour
{
    [SerializeField] private CropsManagement _cropsManagement;
    [SerializeField] private CoinManagement _coinManagement;

    public void Buy(int _price,int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (_coinManagement.nbCoin < _price) return; // si pas assez d'argent
        _coinManagement.Coin(-_price);
        if (_isCarrot) _cropsManagement.Carrots(_quantity);
        if (_isBerries) _cropsManagement.Berries(_quantity);
        if (_isWheat) _cropsManagement.Wheat(_quantity);
    }

    public void Sell(int _price, int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (_isCarrot)
        {
            if (_cropsManagement.nbCarrots < _quantity) return;
            _cropsManagement.Carrots(-_quantity);
            _coinManagement.Coin(_price);
        }
        if (_isBerries)
        {
            if (_cropsManagement.nbBerries < _quantity) return;
            _cropsManagement.Berries(-_quantity);
            _coinManagement.Coin(_price);
        }
        if (_isWheat)
        {
            if (_cropsManagement.nbWheat < _quantity) return;
            _cropsManagement.Wheat(-_quantity);
            _coinManagement.Coin(_price);
        }
    }
}
