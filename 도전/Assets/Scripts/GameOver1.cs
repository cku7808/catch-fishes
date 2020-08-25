using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneToLoad;
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
