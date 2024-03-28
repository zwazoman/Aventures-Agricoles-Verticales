using UnityEngine;

public class BuySell : MonoBehaviour
{
    [SerializeField] private ShopManagement _shopManagement;
    [SerializeField] private CropClass _infos;
    [SerializeField] private int _quantity;
    [SerializeField] private int _factor;
    [SerializeField] private bool _isCarrot;
    [SerializeField] private bool _isBerries;
    [SerializeField] private bool _isWheat;

    private int _buyPrice;
    private int _sellPrice;
    private void Awake()
    {
        _buyPrice = (_infos.buyPrice * _quantity) - (_infos.buyPrice * _factor);
        _sellPrice = (_infos.sellPrice * _quantity) + (_infos.sellPrice * _factor);
    }

    /// <summary>
    /// le joueur achète un objet
    /// </summary>
    public void BuyItem()
    {
        _shopManagement.Buy(_buyPrice, _quantity, _isCarrot, _isBerries, _isWheat);
    }

    /// <summary>
    /// Le joueur vend un objet
    /// </summary>
    public void SellItem()
    {
        _shopManagement.Sell(_sellPrice, _quantity, _isCarrot, _isBerries, _isWheat);
    }
}
