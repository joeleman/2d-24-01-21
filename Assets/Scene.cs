using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    
    public void PlayGameFirst()
    {
        SceneManager.LoadScene("second");
        
    }

    public void PlayGameSecond()
    {
        SceneManager.LoadScene("first");
    }
    
    void Update()
    {
        if(Input.GetKey("w"))
        {
            PlayGameFirst();
        }


        if(Input.GetKey("e"))
        {
            PlayGameSecond();
        }
    }
}
