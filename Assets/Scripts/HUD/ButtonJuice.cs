using System.Collections;
using UnityEngine;

public class ButtonJuice : MonoBehaviour
{
    private Vector2 _initialScale;
    [SerializeField] private bool _money;
    private void Awake()
    {
        _initialScale = transform.localScale;
    }
    public void Click()
    {
        StartCoroutine(Bigger());
        // si money jouer son monnaie sinon jouer pop
    }

    private IEnumerator Bigger()
    {
        transform.localScale *= 1.1f;
        yield return new WaitForSecondsRealtime(0.1f);
        transform.localScale = _initialScale;
    }
}
