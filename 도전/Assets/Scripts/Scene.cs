using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Update()
    {
        if(obj == null)
        {
            StartCoroutine(SceneLoad());
        }
    }
    private IEnumerator SceneLoad()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameOver");
    }
}
