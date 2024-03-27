using UnityEngine;
using UnityEngine.InputSystem;

public class FarmPlot : MonoBehaviour
{
    [SerializeField] private Interact _interact;
    [SerializeField] private Sower _sower;
    [SerializeField] GameObject _sowPanel;
    [SerializeField] private GameObject _carrotsButton;
    [SerializeField] private GameObject _berriesButton;
    [SerializeField] private GameObject _wheatButton;

    private bool _canSow = false;


    private void OnEnable()
    {
        _sowPanel.SetActive(false);
    }

    private void Update()
    {
        _canSow = _interact._canInteract;
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canSow) OpenSowPanel();
    }

    private void OpenSowPanel()
    {
        _sowPanel.SetActive(true);
        if (CropsManagement.instance.nbCarrots == 0) _carrotsButton.SetActive(false); else _carrotsButton.SetActive(true);
        if (CropsManagement.instance.nbBerries == 0) _berriesButton.SetActive(false); else _berriesButton.SetActive(true);
        if (CropsManagement.instance.nbWheat == 0) _wheatButton.SetActive(false); else _wheatButton.SetActive(true);
        Time.timeScale = 0;
    }
}
