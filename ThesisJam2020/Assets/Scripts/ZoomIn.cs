using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoomIn : MonoBehaviour
{

    private int time = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(time);
    }

    private void OnMouseOver()
    {
        CameraFunc.Instance.ChangeCam(1);
        time++;
        
        if (time > 500)
        {
            SceneManager.LoadScene("Car");
        }
    }

    private void OnMouseExit()
    {
        CameraFunc.Instance.ChangeCam(0);
        time = 0;
    }


}
