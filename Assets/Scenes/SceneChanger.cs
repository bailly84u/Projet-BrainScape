using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void goLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void returnMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
