using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour
{
    public void NextLevel(string nameLv)
    {
        SceneManager.LoadScene(nameLv);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }
    public void Quit()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
