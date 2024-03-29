using System.Collections.Generic;
using UnityEngine;

public class LvlEnabled : MonoBehaviour
{
    [SerializeField] private List<GameObject> _coins = new List<GameObject>(); // liste des pi�ces dans le niveau

    /// <summary>
    /// r�active les pi�ces quand le niveau est "selectionn�"
    /// </summary>
    public void ActiveCoins()
    {
        foreach(GameObject _coin in _coins) // pour chaque pi�ce dans le niveau
        {
            _coin.SetActive(true); // activer la pi�ce
        }
    }
}
