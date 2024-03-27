using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private CropClass _infos;
    [HideInInspector] public ExitDoor growDoor;
    private int _growlevel = 0;
    SpriteRenderer SR;
    [SerializeField] Harvester harvester;
    [SerializeField] private Interact _interact;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
        SR.sprite = _infos.initialSprite;
        _interact.normalSprite = _infos.initialSprite; // changement de sprite pour l'interaction
        _interact.interactSprite = _infos.interactInitialSprite;
    }

    public void Start()
    {
        growDoor.OnExit += Grow;
    }

    public void Grow()
    {
        _growlevel += 1;
        if (_growlevel == _infos.growTime) harvester.canHarvest = true;
        if (_growlevel == 1)
        {
            SR.sprite = _infos.sprite1;
            _interact.normalSprite = _infos.sprite1; //changement de sprite pour l'interaction
            _interact.interactSprite = _infos.interactsprite1;
        }
        else
        {
            SR.sprite = _infos.sprite2;
            _interact.normalSprite= _infos.sprite2; // changement de sprite pour l'interaction
            _interact.interactSprite = _infos.interactsprite2;
        }
    }

    private void OnDestroy()
    {
        growDoor.OnExit -= Grow; // retirer ce "Grow" de l'event pour ne pas qu'il soit appelé alors qu'il est détruit
    }
}
