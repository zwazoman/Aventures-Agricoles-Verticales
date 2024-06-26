using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] private CoinSound _coinSound;

    /// <summary>
    /// qund le joueur entre dans ce trigger : les pi�ces poss�d�es sont actualis�es et l'objet est d�sactiv�
    /// </summary>
    /// <param name="collider"></param>
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.layer == 6) // si c'est un joueur
        {
            CoinManagement.Instance.Coin(1); // ajouter une pi�ce
            _coinSound.PlayCoin(); // son de pi�ce
            gameObject.SetActive(false); // d�sactiver la pi�ce
        }
    }
}
