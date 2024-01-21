using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_StartScene : MonoBehaviour
{
    public void OnClick_Button()
    {
        SceneManager.LoadScene("StartScene");
    }
}
