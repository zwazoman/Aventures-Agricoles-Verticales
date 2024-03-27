using UnityEngine;

[CreateAssetMenu(fileName = "Crop", menuName = "Crops")]
public class CropClass : ScriptableObject
{
    public Sprite initialSprite; public Sprite interactInitialSprite;
    public Sprite sprite1; public Sprite interactsprite1;
    public Sprite sprite2; public Sprite interactsprite2;
    public Sprite deadSprite; public Sprite interactDeadSprite;

    [field: SerializeField]
    public int growTime { get; private set; }

    [field: SerializeField]
    public int drops { get; private set; }

    [field : SerializeField]
    public int buyPrice { get;private set; }

    [field: SerializeField]
    public int sellPrice { get; private set; }

    [field: SerializeField]
    public GameObject prefab { get; private set; }
}
