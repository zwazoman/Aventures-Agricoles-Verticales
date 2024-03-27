using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell : MonoBehaviour
{
    [SerializeField] private ShopManagement _shopManagement;
    [SerializeField] private CropClass _infos;
    [SerializeField] private int _quantity;
    [SerializeField] private bool _isCarrot;
    [SerializeField] private bool _isBerries;
    [SerializeField] private bool _isWheat;

    private int _buyPrice;
    private int _sellPrice;
    private void Awake()
    {
        _buyPrice = _infos.buyPrice * _quantity;
        _sellPrice = _infos.sellPrice * _quantity;
    }

    public void BuyItem()
    {
        _shopManagement.Buy(_buyPrice, _quantity, _isCarrot, _isBerries, _isWheat);
    }

   public void SellItem()
   {
       _shopManagement.Sell(_sellPrice, _quantity, _isCarrot, _isBerries, _isWheat);
   }
}
