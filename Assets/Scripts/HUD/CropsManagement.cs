using TMPro;
using UnityEngine;

public class CropsManagement : MonoBehaviour
{
    public static CropsManagement instance;
    
    [SerializeField] public ExitDoor growDoor;

    [SerializeField] private TMP_Text _carrotNumber;
    [SerializeField] private TMP_Text _berriesNumber;
    [SerializeField] private TMP_Text _wheatNumber;

    [HideInInspector] public int nbCarrots;
    [HideInInspector] public int nbBerries;
    [HideInInspector] public int nbWheat;

    private void Awake()
    {
        instance = this; // singleton
        nbCarrots = 5;
        nbBerries = 5;
        nbWheat = 1;
        _carrotNumber.text = nbCarrots.ToString();
        _berriesNumber.text = nbBerries.ToString();
        _wheatNumber.text = nbWheat.ToString();
    }
    public void Carrots(int _number)
    {
        if (_number < -nbCarrots) return; //enlève plus que l'on possède
        nbCarrots += _number;
        _carrotNumber.text = nbCarrots.ToString();
    }
    public void Berries(int _number)
    {
        if (_number < -nbBerries) return; //enlève plus que l'on possède
        nbBerries += _number;
        _berriesNumber.text = nbBerries.ToString();
    }
    public void Wheat(int _number)
    {
        if (_number < -nbWheat) return; //enlève plus que l'on possède
        nbWheat += _number;
        _wheatNumber.text = nbWheat.ToString();
    }

}
