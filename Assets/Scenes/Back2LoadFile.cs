using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back2LoadFile : MonoBehaviour
{
     public void Cancel_Button()
    {
        SceneManager.LoadScene("FileLoad");
    }
}
