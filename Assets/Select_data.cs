using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class Select_data
{
    public static string path;
    public static string[] sid;
    public static string[] condition;
}

[Serializable]
public class Select_JSON_data
{
    public string path;
    public string[] sid;
    public string[] condition;
}