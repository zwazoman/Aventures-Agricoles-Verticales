using UnityEngine;

public class ShopManagement : MonoBehaviour
{

    public void Buy(int _price,int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (CoinManagement.instance.nbCoin < _price) return; // si pas assez d'argent
        CoinManagement.instance.Coin(-_price);
        if (_isCarrot) CropsManagement.instance.Carrots(_quantity);
        if (_isBerries) CropsManagement.instance.Berries(_quantity);
        if (_isWheat) CropsManagement.instance.Wheat(_quantity);
    }

    public void Sell(int _price, int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (_isCarrot)
        {
            if (CropsManagement.instance.nbCarrots < _quantity) return; // si pas assez de carottes
            CropsManagement.instance.Carrots(-_quantity);
            CoinManagement.instance.Coin(_price);
        }
        if (_isBerries)
        {
            if (CropsManagement.instance.nbBerries < _quantity) return; // pas assez de baies
            CropsManagement.instance.Berries(-_quantity);
            CoinManagement.instance.Coin(_price);
        }
        if (_isWheat)
        {
            if (CropsManagement.instance.nbWheat < _quantity) return; // pas assez de blé
            CropsManagement.instance.Wheat(-_quantity);
            CoinManagement.instance.Coin(_price);
        }
    }
}
