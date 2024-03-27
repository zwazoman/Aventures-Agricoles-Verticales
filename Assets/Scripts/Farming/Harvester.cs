using System.Net;
using UnityEngine;
using UnityEngine.InputSystem;

public class Harvester : MonoBehaviour
{
    [HideInInspector] public bool canHarvest;
    [HideInInspector] public GameObject shovel;
    public bool isCarrot = false;
    public bool isBerries = false;
    public bool isWheat = false;
    public bool isDead = false;

    private bool _canInteract;
    [SerializeField] private Interact _interact;
    [SerializeField] private CropClass _infos;
    //[SerializeField] private GameObject _notGrowedPanel;

    private void Update()
    {
        _canInteract = _interact._canInteract; 
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if(context.performed && _canInteract)
        {
            if (canHarvest) Harvest(); else print("pas pret");//_notGrowedPanel.SetActive(true);
        }
    }

    private void Harvest() // switchcase
    {
        if (!isDead)
        {
            if (isCarrot) CropsManagement.instance.Carrots(_infos.drops);
            if (isBerries) CropsManagement.instance.Berries(_infos.drops); 
            if (isWheat) CropsManagement.instance.Wheat(_infos.drops);
        }
        shovel.SetActive(true);
        Destroy(gameObject);
    }
}
