using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WheatUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _wheatNumber;

    public void ChangeWheat(int _nbWheat)
    {
        _wheatNumber.text = _nbWheat.ToString();
    }
}
