using UnityEngine;
using UnityEngine.InputSystem;

public class Shop : MonoBehaviour
{
    [SerializeField] private Interact _interact;
    [SerializeField] private GameObject _shopPanel;
    private bool _canInteract;

    private void Update()
    {
        _canInteract = _interact._canInteract;
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (_canInteract)
        {
            OpenShopPanel();
        }
    }

    private void OpenShopPanel()
    {
        _shopPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
