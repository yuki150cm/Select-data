using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Condition : MonoBehaviour
{
    public InputField inputField_C;
    public static string InputCondition;
    public static string[] arr_C;
    // Start is called before the first frame update
    void Start()
    {
        //Componentを扱えるようにする
             inputField_C = inputField_C.GetComponent<InputField> ();

    }

    public void InputText(){
        InputCondition = inputField_C.text;
        arr_C = InputCondition.Split(',');
        Select_data.condition = arr_C;
        Debug.Log(Select_data.condition[0]);
     }
}
