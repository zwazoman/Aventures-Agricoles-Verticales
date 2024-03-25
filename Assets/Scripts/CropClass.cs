using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "Crops")]
public class CropClass : ScriptableObject
{
    [SerializeField] private Sprite _sprite1;
    [SerializeField] private Sprite _sprite2;
    [SerializeField] private Sprite _sprite3;
    [SerializeField] private Sprite _deadSprite;

    [field: SerializeField]
    public int growTime { get; private set; }

    [field: SerializeField]
    public int drops { get; private set; }

    [field : SerializeField]
    public int buyPrice { get;private set; }

    [field: SerializeField]
    public int sellPrice { get; private set; }

}
