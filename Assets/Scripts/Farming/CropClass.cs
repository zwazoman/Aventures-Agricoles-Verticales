using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "Crops")]
public class CropClass : ScriptableObject
{
    [field : SerializeField]
    public Sprite initialSprite { get;private set; }

    [field: SerializeField]
    public Sprite sprite1 { get; private set; }

    [field: SerializeField]
    public Sprite sprite2 { get; private set; }

    [field: SerializeField]
    public Sprite deadSprite { get; private set; }

    [field: SerializeField]
    public Sprite interactInitialSprite { get; private set; }

    [field: SerializeField]
    public Sprite interactsprite1 { get; private set; }

    [field: SerializeField]
    public Sprite interactsprite2 { get; private set; }

    [field: SerializeField]
    public Sprite interactDeadSprite { get; private set; }

    [field: SerializeField]
    public int growTime { get; private set; }

    [field: SerializeField]
    public int drops { get; private set; }

    [field : SerializeField]
    public int buyPrice { get;private set; }

    [field: SerializeField]
    public int sellPrice { get; private set; }

    [field: SerializeField]
    public GameObject Prefab { get; private set; }

    [field: SerializeField]
    public bool IsCarrot { get; private set; }

    [field: SerializeField]
    public bool IsBerries { get; private set; }

    [field: SerializeField]
    public bool IsWheat { get; private set; }
}
