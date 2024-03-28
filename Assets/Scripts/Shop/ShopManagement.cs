using UnityEngine;

public class ShopManagement : MonoBehaviour
{

    /// <summary>
    /// gère l'argent et les ressources suite a un achat
    /// </summary>
    /// <param name="_price"></param>
    /// <param name="_quantity"></param>
    /// <param name="_isCarrot"></param>
    /// <param name="_isBerries"></param>
    /// <param name="_isWheat"></param>
    public void Buy(int _price,int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (CoinManagement.Instance.NbCoin < _price) return; // si pas assez d'argent
        CoinManagement.Instance.Coin(-_price);
        if (_isCarrot) CropsManagement.Instance.Carrots(_quantity);
        if (_isBerries) CropsManagement.Instance.Berries(_quantity);
        if (_isWheat) CropsManagement.Instance.Wheat(_quantity);
    }

    /// <summary>
    /// gère l'argent et les ressources suite a une vente
    /// </summary>
    /// <param name="_price"></param>
    /// <param name="_quantity"></param>
    /// <param name="_isCarrot"></param>
    /// <param name="_isBerries"></param>
    /// <param name="_isWheat"></param>
    public void Sell(int _price, int _quantity, bool _isCarrot = false, bool _isBerries = false, bool _isWheat = false)
    {
        if (_isCarrot)
        {
            if (CropsManagement.Instance.NbCarrots < _quantity) return; // si pas assez de carottes
            CropsManagement.Instance.Carrots(-_quantity);
            CoinManagement.Instance.Coin(_price);
        }
        if (_isBerries)
        {
            if (CropsManagement.Instance.NbBerries < _quantity) return; // pas assez de baies
            CropsManagement.Instance.Berries(-_quantity);
            CoinManagement.Instance.Coin(_price);
        }
        if (_isWheat)
        {
            if (CropsManagement.Instance.NbWheat < _quantity) return; // pas assez de blé
            CropsManagement.Instance.Wheat(-_quantity);
            CoinManagement.Instance.Coin(_price);
        }
    }
}
