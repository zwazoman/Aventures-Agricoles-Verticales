using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarrotUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _carrotNumber;
    public void ChangeCarrots(int _nbCarrots)
    {
        _carrotNumber.text = _nbCarrots.ToString();
    }
}
