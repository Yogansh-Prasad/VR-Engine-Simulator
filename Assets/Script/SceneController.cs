using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoToScene1()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToScene2()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToScene3()
    {
        SceneManager.LoadScene(2);
    }
}
