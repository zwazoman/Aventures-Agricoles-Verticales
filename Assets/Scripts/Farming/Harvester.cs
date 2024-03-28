using UnityEngine;
using UnityEngine.InputSystem;

public class Harvester : MonoBehaviour
{
    public bool CanHarvest { get; set; }
    public GameObject Shovel { get; set; }
    public bool IsCarrot { get; set; }
    public bool IsBerries { get; set; }
    public bool IsWheat { get; set; }
    public bool IsDead { get; set; }

    private bool _canInteract;

    [SerializeField] private Interact _interact;
    [SerializeField] private CropClass _infos;
    //[SerializeField] private GameObject _notGrowedPanel;

    private void Update()
    {
        _canInteract = _interact._canInteract; 
    }

    /// <summary>
    /// interaction avec l'input system
    /// </summary>
    /// <param name="context"></param>
    public void Interact(InputAction.CallbackContext context)
    {
        if(context.performed && _canInteract)
        {
            if (CanHarvest) Harvest(); else print("pas pret");//_notGrowedPanel.SetActive(true);
        }
    }

    /// <summary>
    /// vérifie et gère la récolte des plantes par le joueur
    /// </summary>
    private void Harvest() // switchcase
    {
        if (!IsDead)
        {
            if (IsCarrot) CropsManagement.Instance.Carrots(_infos.drops);
            if (IsBerries) CropsManagement.Instance.Berries(_infos.drops); 
            if (IsWheat) CropsManagement.Instance.Wheat(_infos.drops);
        }
        Shovel.SetActive(true);
        Destroy(gameObject);
    }
}
