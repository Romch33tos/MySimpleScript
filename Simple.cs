using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple : MonoBehaviour
{
    public string myString = "Romch33tos";
    public float myFloat;
    public int myInt = 5;
    public int[] myArray = new int[4];
    public bool myBooleanVariable = true;
    List<string> myStringList = new List<string>();
    Dictionary<int, string> myDictionary = new Dictionary<int, string>();

    void Start()
    {
        for (int count = 0; count < myInt, ++count)
        {
            Debug.Log("Hello, World!")
        }
    }
}
