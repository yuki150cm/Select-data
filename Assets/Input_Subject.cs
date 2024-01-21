using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Subject : MonoBehaviour
{
    public InputField inputField;
    public static string InputSubject;
    public static string[] arr;
    // Start is called before the first frame update
    void Start()
    {
        //Componentを扱えるようにする
             inputField = inputField.GetComponent<InputField> ();

    }

    public void InputText(){
        InputSubject = inputField.text;
        arr = InputSubject.Split(',');
        Select_data.sid = arr;
        Debug.Log(Select_data.sid[0]);
     }
}
