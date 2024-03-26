using TMPro;
using UnityEngine;

public class CropsManagement : MonoBehaviour
{
    [SerializeField] public ExitDoor growDoor;

    [SerializeField] private TMP_Text _carrotNumber;
    [SerializeField] private TMP_Text _berriesNumber;
    [SerializeField] private TMP_Text _wheatNumber;

    [HideInInspector] public int nbCarrots;
    [HideInInspector] public int nbBerries;
    [HideInInspector] public int nbWheat;

    private void Awake()
    {
        nbCarrots = 5;
        nbBerries = 5;
        nbWheat = 5;
        _carrotNumber.text = nbCarrots.ToString();
        _berriesNumber.text = nbBerries.ToString();
        _wheatNumber.text = nbWheat.ToString();
    }
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
