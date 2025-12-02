using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class ChangeToMultiPlayer : MonoBehaviour
{
    // Update is called once per frame
    public void SwitchScene()
    {
        SceneManager.LoadScene("Assets/Scenes/Multplayer.unity");
    }
}
