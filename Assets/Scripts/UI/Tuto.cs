using UnityEngine;

public class Tuto : MonoBehaviour
{
    [SerializeField] private GameObject _tutoPanel;
    void Start()
    {
        _tutoPanel.SetActive(true);    
        Time.timeScale = 0f;
    }

}
