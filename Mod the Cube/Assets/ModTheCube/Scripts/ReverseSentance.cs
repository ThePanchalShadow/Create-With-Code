using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseSentance : MonoBehaviour
{
    [SerializeField] string num1;
    string num3;
    // Start is called before the first frame update
    void Start()
    {
        string[] num2 = num1.Split(' ');
        for (int i = num2.Length - 1; i >= 0; i--)
        {
            num3 = num3 + num2[i] + " ";
        }
        Debug.Log(num3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
