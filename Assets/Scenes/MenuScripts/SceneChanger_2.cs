using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("o"))
        {
            print("o key is held down");
            SceneManager.LoadScene("world_map");
        }
        if (Input.GetKey("p"))
        {
            print("p key is being held down");
            SceneManager.LoadScene("menu_1");
        }
    }
}