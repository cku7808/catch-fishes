using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.left * Random.Range(20.0f, 30.0f) * Time.deltaTime * Random.Range(0,11);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Destroy(gameObject);
            ScoreManager.instance.score += 5;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("FishDestroyArea"))
        {
            Destroy(gameObject);
        }
    }
}
