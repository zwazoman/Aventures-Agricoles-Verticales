using UnityEngine;
using UnityEngine.InputSystem;

public class FarmPlot : MonoBehaviour
{
    [SerializeField] private Interact _interact;
    [SerializeField] private GameObject _sowPanel;
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

    /// <summary>
    /// interaction input system (e)
    /// </summary>
    /// <param name="context"></param>
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canSow) OpenSowPanel();
    }

    /// <summary>
    /// ouvre le panel d'ui et active les boutons seulement si le joueur possède 1 ou + du légume lié au bouton
    /// </summary>
    private void OpenSowPanel()
    {
        _sowPanel.SetActive(true);
        if (CropsManagement.Instance.NbCarrots == 0) _carrotsButton.SetActive(false); else _carrotsButton.SetActive(true);
        if (CropsManagement.Instance.NbBerries == 0) _berriesButton.SetActive(false); else _berriesButton.SetActive(true);
        if (CropsManagement.Instance.NbWheat == 0) _wheatButton.SetActive(false); else _wheatButton.SetActive(true);
        Time.timeScale = 0;
    }
}
