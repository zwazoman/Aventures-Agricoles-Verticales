using TMPro;
using UnityEngine;

public class CropsManagement : MonoBehaviour
{
    public static CropsManagement Instance;
    [field: SerializeField] public ExitDoor GrowDoor { get; private set; }

    [SerializeField] private TMP_Text _carrotNumber;
    [SerializeField] private TMP_Text _berriesNumber;
    [SerializeField] private TMP_Text _wheatNumber;

    public int NbCarrots { get; private set; }
    public int NbBerries { get; private set; }
    public int NbWheat { get; private set; }

    private void Awake()
    {
        Instance = this; // singleton
        NbCarrots = 2;
        _carrotNumber.text = NbCarrots.ToString();
        _berriesNumber.text = NbBerries.ToString();
        _wheatNumber.text = NbWheat.ToString();
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer des carottes
    /// </summary>
    /// <param name="_number"></param>
    public void Carrots(int _number)
    {
        if (_number < -NbCarrots) return; //enlève plus que l'on possède
        NbCarrots += _number;
        _carrotNumber.text = NbCarrots.ToString();
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer des berries
    /// </summary>
    /// <param name="_number"></param>
    public void Berries(int _number)
    {
        if (_number < -NbBerries) return; //enlève plus que l'on possède
        NbBerries += _number;
        _berriesNumber.text = NbBerries.ToString();
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer du blé
    /// </summary>
    /// <param name="_number"></param>
    public void Wheat(int _number)
    {
        if (_number < -NbWheat) return; //enlève plus que l'on possède
        NbWheat += _number;
        _wheatNumber.text = NbWheat.ToString();
    }

}
