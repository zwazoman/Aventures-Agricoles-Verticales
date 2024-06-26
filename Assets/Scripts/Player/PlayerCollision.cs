using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private BounceSound _bounceSound;
    /// <summary>
    /// gestion des collisions du joueur avec l'environnement
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 7) // si l'objet est une killzone
        {
            Death.Instance.Die();
        }
        if(collision.gameObject.layer == 9)
        {
            _bounceSound.PlayBounce(); // joue le son de rebond
        }
    }
}
