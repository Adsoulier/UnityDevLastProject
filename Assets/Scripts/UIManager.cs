using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadLevelDog()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevelFox()
    {
        SceneManager.LoadScene(2);
    }
}
