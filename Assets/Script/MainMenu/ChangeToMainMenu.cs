using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ChangeToMainMenu : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("Assets/MainMenu.unity");
    }
}
