using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIshManager : MonoBehaviour
{
    // Update is called once per frame
    public GameObject fishObject;
    float deltaTime = 0.0f;
    float spawnTime = 2.0f;

    void Update()
    {
        deltaTime += Time.deltaTime;

        if(deltaTime > spawnTime)
        {
            deltaTime = 0.0f;
            GameObject obj = Instantiate(fishObject) as GameObject;

            float x = Random.Range(300, 500);
            float y = Random.Range(-60, 70);
            obj.transform.position = new Vector3(x, y, -2.0f);
        }
    }
}
