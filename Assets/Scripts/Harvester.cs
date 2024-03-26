using UnityEngine;
using UnityEngine.InputSystem;

public class Harvester : MonoBehaviour
{
    [HideInInspector] public bool canHarvest;
    [HideInInspector] public CropsManagement cropManagement;
    [HideInInspector] public GameObject shovel;
    public bool isCarrot = false;
    public bool isBerries = false;
    public bool isWheat = false;
    public Sprite normalSprite;
    public Sprite interactSprite;

    private bool _canInteract;
    private SpriteRenderer _SR;
    [SerializeField] private CropClass _infos;
    [SerializeField] private GameObject _notGrowedPanel;

    private void Awake()
    {
        _SR = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
        _SR.sprite = interactSprite;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
        _SR.sprite = normalSprite;
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if(context.performed && _canInteract)
        {
            if (canHarvest) Harvest(); else print("pas pret");//_notGrowedPanel.SetActive(true);
        }
    }

    private void Harvest()
    {
        if (isCarrot) cropManagement.Carrots(_infos.drops); else if (isBerries) cropManagement.Berries(_infos.drops); else cropManagement.Wheat(_infos.drops);
        shovel.SetActive(true);
        Destroy(gameObject);
    }
}
