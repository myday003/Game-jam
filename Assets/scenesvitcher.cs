
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesvitcher : MonoBehaviour
{
    public string WhichSwitch;

    public void scenesvitch()
    {
        //SceneManager.LoadScene(WhichSwitch);
        print(WhichSwitch);
    }
    public void exit()
    {
        Application.Quit();
        print("успешно");
    }
}
