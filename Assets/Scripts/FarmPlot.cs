using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FarmPlot : MonoBehaviour
{
    [SerializeField] private CropsManagement _cropsManagement;

    private bool _canSow = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            _canSow = true;
            print("in range");
            //changer le sprite
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            _canSow = false;
            print("out of range");
            //rechanger le sprite
        }
    }
    public void Interact(InputAction.CallbackContext context)
    {
        if (context.performed && _canSow) OpenSowPanel();

    }

    private void OpenSowPanel()
    {
        _cropsManagement._sowPanel.SetActive(true);
        if (_cropsManagement.nbCarrots == 0) _cropsManagement._carrotsButton.SetActive(false);
        if (_cropsManagement.nbBerries == 0) _cropsManagement._berriesButton.SetActive(false);
        if (_cropsManagement.nbWheat == 0) _cropsManagement._wheatButton.SetActive(false);
        Time.timeScale = 0;
    }
}
