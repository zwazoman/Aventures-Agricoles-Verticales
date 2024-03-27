using UnityEngine;
using UnityEngine.InputSystem;

public class FarmPlot : MonoBehaviour
{
    private SpriteRenderer _SR;
    private Sprite _normalSprite;

    [SerializeField] private CropsManagement _cropsManagement;
    [SerializeField] private Sower _sower;
    [SerializeField] GameObject _sowPanel;
    [SerializeField] private Sprite _interactSprite;
    [SerializeField] GameObject _carrotsButton;
    [SerializeField] GameObject _berriesButton;
    [SerializeField] GameObject _wheatButton;

    private bool _canSow = false;

    private void Awake()
    {
        _sower._cropsManagement = _cropsManagement;
        _SR = GetComponent<SpriteRenderer>();
        _normalSprite = _SR.sprite;
    }

    private void OnEnable()
    {
        _sowPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canSow = true;
        _SR.sprite = _interactSprite;
        print("in range");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canSow = false;
        _SR.sprite = _normalSprite;
        print("out of range");
    }

    public void Interact(InputAction.CallbackContext context)
    {
        if (!_canSow) return;
        if (context.performed) OpenSowPanel();
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
