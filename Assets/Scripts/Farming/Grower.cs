using UnityEngine;

public class Grower : MonoBehaviour
{
    private ExitDoor _growDoor;
    private int _growlevel = 0;
    private SpriteRenderer _SR;

    [SerializeField] private CropClass _infos;
    [SerializeField] private Harvester harvester;
    [SerializeField] private Interact _interact;

    private void Awake()
    {
        _growDoor = CropsManagement.Instance.GrowDoor;
        _SR = GetComponent<SpriteRenderer>();
        _SR.sprite = _infos.initialSprite;
        _interact.interactSprite = _infos.interactInitialSprite;
    }

    public void Start()
    {
        _growDoor.OnExit += Grow;
    }

    /// <summary>
    /// gère la pousse des plantes quand le joueur intéragit avec la porte
    /// </summary>
    public void Grow()
    {
        _growlevel += 1;
        if (_growlevel == _infos.growTime) harvester.CanHarvest = true;
        if (_growlevel == 1)
        {
            _SR.sprite = _infos.sprite1;
            _interact.normalSprite = _infos.sprite1; //changement de sprite pour l'interaction
            _interact.interactSprite = _infos.interactsprite1;
        }
        else
        {
            _SR.sprite = _infos.sprite2;
            _interact.normalSprite= _infos.sprite2; // changement de sprite pour l'interaction
            _interact.interactSprite = _infos.interactsprite2;
        }
    }

    private void OnDestroy()
    {
        _growDoor.OnExit -= Grow; // retirer ce "Grow" de l'event pour ne pas qu'il soit appelé alors qu'il est détruit
    }
}
