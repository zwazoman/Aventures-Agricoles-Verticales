using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BerriesUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _berriesNumber;

    public void ChangeBerries(int _nbBerries)
    {
        _berriesNumber.text = _nbBerries.ToString();
    }
}
