using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void OK_Button()
    {
        Select_JSON_data data = new Select_JSON_data();
        data.path = Select_data.path;
        data.sid = Select_data.sid;
        data.condition = Select_data.condition;
        string json = JsonUtility.ToJson(data);

        System.IO.File.WriteAllText("../Plot_data/Assets/Resources/JSON/Select_data.json",json);
    }
}
