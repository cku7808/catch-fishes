using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneToLoad;
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
