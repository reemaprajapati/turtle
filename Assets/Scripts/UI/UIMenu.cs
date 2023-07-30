using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] Button _loadTurtle;

    void Start()
    {
        _loadTurtle.onClick.AddListener(LoadTurtle);
    }

    private void LoadTurtle()
    {
        ScenesManager.Instance.LoadTurtle();
    }
}
