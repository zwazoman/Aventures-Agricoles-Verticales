using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    /// <summary>
    /// qund le joueur entre dans ce trigger : les pièces possédées sont actualisées et l'objet est désactivé
    /// </summary>
    /// <param name="collider"></param>
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 6) // si c'est un joueur
        {
            CoinManagement.Instance.Coin(1); // ajouter une pièce
            AudioManager.Instance.PlaySFX(AudioManager.Instance.CoinSound); // son de pièce
            gameObject.SetActive(false); // désactiver la pièce
        }
    }
}
