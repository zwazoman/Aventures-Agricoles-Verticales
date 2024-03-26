using UnityEngine;
using UnityEngine.InputSystem;

public class Harvester : MonoBehaviour
{
    public bool canHarvest;
    private bool _canInteract;
    public GameObject crop;

    [SerializeField] private GameObject _notGrowedPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
        //changer le sprite
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
        //rechanger le sprite
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if(context.performed && _canInteract)
        {
            if (canHarvest) Harvest(); else _notGrowedPanel.SetActive(true);
        }
    }

    private void Harvest()
    {

    }
}
