using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;        
    }

    public enum Scene
    {
        Menu,
        Turtle
    }

    public void LoadTurtle()
    {
        SceneManager.LoadScene(Scene.Turtle.ToString());
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Menu.ToString());
    }


}
