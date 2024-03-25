using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlotInteraction : MonoBehaviour
{
    [SerializeField] private GameObject _sowPanel;
    [SerializeField] private GameObject _carrotsButton;
    [SerializeField] private GameObject _berriesButton;
    [SerializeField] private GameObject _wheatButton;
    private bool _canSow = false;
    public bool isSowed = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6 && !isSowed)
        {
            _canSow = true;
            print("in range");
            //changer le sprite
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6 && !isSowed)
        {
            _canSow = false;
            print("out of range");
            //rechanger le sprite
        }
    }
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canSow)
        {
            OpenSowPanel();
        }
    }

    private void OpenSowPanel()
    {
        _sowPanel.SetActive(true);
        //si nbcarrots > 0 : _carrotsButton.setActive(true);
        // "
        // "
        Time.timeScale = 0;
    }
}
