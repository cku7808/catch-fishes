using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public UnityEngine.UI.Text text;
    float time = 60.0f;
    public static int plusTime = 0;
    // Start is called before the first frame update

    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            time += plusTime;
            text.text = "Time : " + Mathf.Round(time);
        }
        plusTime = 0;
    }
}
