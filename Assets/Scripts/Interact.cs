using UnityEngine;

public class Interact : MonoBehaviour
{
    private SpriteRenderer _SR;

    [HideInInspector] public bool _canInteract;
    [HideInInspector] public Sprite normalSprite;
    public Sprite interactSprite;

    private void Awake()
    {
        _SR = GetComponent<SpriteRenderer>();
        normalSprite = _SR.sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
        _SR.sprite = interactSprite;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
        _SR.sprite = normalSprite;
    }
}
