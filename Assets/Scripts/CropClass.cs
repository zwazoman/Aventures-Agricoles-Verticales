using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "Crops")]
public class CropClass : ScriptableObject
{
    public Sprite _sprite1;
    public Sprite _sprite2;
    public Sprite _deadSprite;

    [field: SerializeField]
    public int growTime { get; private set; }

    [field: SerializeField]
    public int drops { get; private set; }

    [field : SerializeField]
    public int buyPrice { get;private set; }

    [field: SerializeField]
    public int sellPrice { get; private set; }

}
