using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : MonoBehaviour
{
    public GameObject itemObject;
    float deltaTime = 0.0f;
    // Update is called once per frame
    void Update()
    {
        float spawnTime = Random.Range(5, 50);
        deltaTime += Time.deltaTime;

        if (deltaTime > spawnTime)
        {
            deltaTime = 0.0f;
            GameObject obj = Instantiate(itemObject) as GameObject;

            float x = Random.Range(0, 280);
            float y = Random.Range(75, 80);
            obj.transform.position = new Vector3(x, y, -2.0f);
        }
    }
}
