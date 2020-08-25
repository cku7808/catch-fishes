using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.down * Random.Range(10, 20) * Time.deltaTime * Random.Range(0, 11);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            Destroy(gameObject);
        }
        if(other.gameObject.layer == LayerMask.NameToLayer("ItemDestroyArea"))
        {
            Destroy(gameObject);
        }
    }
}
