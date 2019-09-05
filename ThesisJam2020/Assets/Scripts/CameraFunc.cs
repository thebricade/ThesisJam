using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFunc : MonoSingleton<CameraFunc>
{
    public GameObject[] camera1 = new GameObject[3];
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ChangeCam(int i)
    {
        for (int x = 0; x < camera1.Length; x++)
        {
            if (camera1[i] != null)
            {
                if(x !=i ) camera1[x].SetActive(false);
                else camera1[x].SetActive(true);
            }
        }
    }
}
