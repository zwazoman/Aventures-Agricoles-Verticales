using UnityEngine;
using UnityEngine.InputSystem;

public class FarmPlot : MonoBehaviour
{
    [SerializeField] private CropsManagement _cropsManagement;
    [SerializeField] private Interact _interact;
    [SerializeField] private Sower _sower;
    [SerializeField] GameObject _sowPanel;
    [SerializeField] private GameObject _carrotsButton;
    [SerializeField] private GameObject _berriesButton;
    [SerializeField] private GameObject _wheatButton;

    private bool _canSow = false;

    private void Awake()
    {
        _sower._cropsManagement = _cropsManagement;
    }

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
        if (_cropsManagement.nbCarrots == 0) _carrotsButton.SetActive(false);
        if (_cropsManagement.nbBerries == 0) _berriesButton.SetActive(false);
        if (_cropsManagement.nbWheat == 0) _wheatButton.SetActive(false);
        Time.timeScale = 0;
    }
}
