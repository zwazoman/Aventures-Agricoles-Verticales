using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour
{
    [SerializeField] private CropClass _infos;
    private int _growlevel = 0;
    SpriteRenderer SR;
    [SerializeField] Harvester harvester;

    private void Awake()
    {
        SR = GetComponent<SpriteRenderer>();
    }

    public void Grow()
    {
        if (_growlevel == _infos.growTime) harvester.canHarvest = true;
        SR.sprite = _growlevel == 0 ? _infos._sprite1 : _infos._sprite2;
    }
}
