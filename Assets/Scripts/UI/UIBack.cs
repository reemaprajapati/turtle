using UnityEngine;
using UnityEngine.UI;

public class UIBack : MonoBehaviour
{
    [SerializeField] Button _back;

    void Start()
    {
        _back.onClick.AddListener(LoadMenu);
    }

    private void LoadMenu()
    {
        ScenesManager.Instance.LoadMainMenu();
    }
}
