using UnityEngine;

public class Interact : MonoBehaviour
{
    private SpriteRenderer _SR;

     public bool _canInteract { get; private set; }
     public Sprite normalSprite { get; set; }

     [field:SerializeField]
     public Sprite interactSprite { get; set; }

    private void Awake()
    {
        _SR = GetComponent<SpriteRenderer>();
        normalSprite = _SR.sprite;
    }

    /// <summary>
    /// si le joueur est dans le trigger  : il peut interagir
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _canInteract = true;
        _SR.sprite = interactSprite;
    }

    /// <summary>
    /// si il sort du trigger il ne peut plus interagir
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        _canInteract = false;
        _SR.sprite = normalSprite;
    }
}
