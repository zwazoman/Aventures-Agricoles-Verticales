using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private TMP_Text _carrotNumber;
    [SerializeField] private TMP_Text _berriesNumber;
    [SerializeField] private TMP_Text _wheatNumber;

    public int carrots;
    public int berries;
    public int wheat;

    public void Carrots(int number)
    {
        _carrotNumber.text = carrots + number.ToString();
    }
    public void Berries(int number)
    {
        _berriesNumber.text = berries + number.ToString();
    }
    public void Wheat(int number)
    {
        _wheatNumber.text = wheat + number.ToString();
    }

}
