using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadLevelDog()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadLevelCat()
    {
        SceneManager.LoadScene(2);
    }
}
