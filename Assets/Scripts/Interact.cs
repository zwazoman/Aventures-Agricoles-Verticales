using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    private SpriteRenderer _SR;

    //public bool _canInteract;
    private Sprite _normalSprite;
    public Sprite interactSprite;

    private void Awake()
    {
        _SR = GetComponent<SpriteRenderer>();
        _normalSprite = _SR.sprite;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //_canInteract = true;
        _SR.sprite = interactSprite;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //_canInteract = false;
        _SR.sprite = _normalSprite;
    }
}
