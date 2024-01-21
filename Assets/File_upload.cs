using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class File_upload : MonoBehaviour
{
    public static string path;
    
    public void OnClick()
    {
        //パスの取得
        path = EditorUtility.OpenFilePanel("", "", "json");
        Select_data.path = path;
        Debug.Log(Select_data.path);
    }
}
