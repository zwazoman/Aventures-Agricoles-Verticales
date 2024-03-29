using UnityEngine;
using UnityEngine.InputSystem;

public class Shop : MonoBehaviour
{
    [SerializeField] private Interact _interact;
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private ShopSound _shopSound;

    private bool _canInteract;

    private void Start()
    {
        _interact.OnInteract += OpenShopPanel;
    }

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
        _shopSound.PlayShop(); // joue le son de boutique
        Time.timeScale = 0f;
    }
}
