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
    }

    /// <summary>
    /// fais grossir puis rétrécir le bouton
    /// </summary>
    /// <returns></returns>
    private IEnumerator Bigger()
    {
        transform.localScale *= 1.1f;
        yield return new WaitForSecondsRealtime(0.1f);
        transform.localScale = _initialScale;
    }
}
