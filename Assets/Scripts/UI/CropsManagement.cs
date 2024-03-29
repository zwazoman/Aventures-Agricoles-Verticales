using TMPro;
using UnityEngine;

public class CropsManagement : MonoBehaviour
{
    public static CropsManagement Instance;
    [field: SerializeField] public ExitDoor GrowDoor { get; private set; }

    [SerializeField] private CarrotUI _carrotUI;
    [SerializeField] private BerriesUI _berriesUI;
    [SerializeField] private WheatUI _wheatUI;

    public int NbCarrots { get; private set; }
    public int NbBerries { get; private set; }
    public int NbWheat { get; private set; }

    private void Awake()
    {
        Instance = this; // singleton
        NbCarrots = 2;
        _carrotUI.ChangeCarrots(NbCarrots);
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer des carottes
    /// </summary>
    /// <param name="_number"></param>
    public void Carrots(int _number)
    {
        if (_number < -NbCarrots) return; //enlève plus que l'on possède
        NbCarrots += _number;
        _carrotUI.ChangeCarrots(NbCarrots);
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer des berries
    /// </summary>
    /// <param name="_number"></param>
    public void Berries(int _number)
    {
        if (_number < -NbBerries) return; //enlève plus que l'on possède
        NbBerries += _number;
        _berriesUI.ChangeBerries(NbBerries);
    }

    /// <summary>
    /// méthode servant à ajouter ou retirer du blé
    /// </summary>
    /// <param name="_number"></param>
    public void Wheat(int _number)
    {
        if (_number < -NbWheat) return; //enlève plus que l'on possède
        NbWheat += _number;
        _wheatUI.ChangeWheat(NbWheat);
    }

}
