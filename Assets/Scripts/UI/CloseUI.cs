using UnityEngine;
using UnityEngine.InputSystem;

public class CloseUI : MonoBehaviour
{
    [SerializeField] private GameObject _panelToClose;

    /// <summary>
    /// appelle close lors de l'input action "Close" (echap)
    /// </summary>
    /// <param name="context"></param>
    public void ClosePressed(InputAction.CallbackContext context)
    {
        if (context.performed) Close();
    }

    /// <summary>
    /// desactive le panel séléctionné et restore le cours du temps
    /// </summary>
    public void Close()
    {
        _panelToClose.SetActive(false);
        Time.timeScale = 1.0f;
    }
}
