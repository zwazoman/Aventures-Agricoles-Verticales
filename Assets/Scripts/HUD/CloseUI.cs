using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private GameObject _panelToClose;

    public void ClosePressed(InputAction.CallbackContext context)
    {
        if (context.performed) Close();
    }

    public void Close()
    {
        _panelToClose.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
