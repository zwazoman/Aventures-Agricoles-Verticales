using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CropsManagement : MonoBehaviour
{
    [SerializeField] private TMP_Text _carrotNumber;
    [SerializeField] private TMP_Text _berriesNumber;
    [SerializeField] private TMP_Text _wheatNumber;

    [HideInInspector] public int nbCarrots;
    [HideInInspector] public int nbBerries;
    [HideInInspector] public int nbWheat;

    [SerializeField] public GameObject _sowPanel;
    [SerializeField] public GameObject _carrotsButton;
    [SerializeField] public GameObject _berriesButton;
    [SerializeField] public GameObject _wheatButton;

    //singleton raf
    public void Carrots(int _number)
    {
        nbCarrots += _number;
        _carrotNumber.text = nbCarrots.ToString();
    }
    public void Berries(int _number)
    {
        nbBerries += _number;
        _berriesNumber.text = nbBerries.ToString();
    }
    public void Wheat(int _number)
    {
        nbWheat += _number;
        _wheatNumber.text = nbWheat.ToString();
    }

}
