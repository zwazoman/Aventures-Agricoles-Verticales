using System.Collections.Generic;
using UnityEngine;

public class LvlEnabled : MonoBehaviour
{
    [SerializeField] private List<GameObject> _coins = new List<GameObject>(); // liste des pièces dans le niveau

    /// <summary>
    /// réactive les pièces quand le niveau est "selectionné"
    /// </summary>
    public void ActiveCoins()
    {
        foreach(GameObject _coin in _coins) // pour chaque pièce dans le niveau
        {
            _coin.SetActive(true); // activer la pièce
        }
    }
}
