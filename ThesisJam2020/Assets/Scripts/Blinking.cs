using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Blinking : MonoBehaviour
{
    public GameObject blinkObject, blinkObjectReverse;
    public GameObject CameraForward, CameraBackwards;
    private VideoPlayer blinkVideo, blinkVideoReverse;

    private bool finishedBlinking;
    private double blinkVideoLength, currentTime;
    
    // Start is called before the first frame update
    void Start()
    {
        blinkVideo = blinkObject.GetComponent<VideoPlayer>();
        blinkVideoReverse = blinkObjectReverse.GetComponent<VideoPlayer>();
        blinkVideo.time = 1;
        blinkVideoReverse.time = 1;

        blinkVideoLength = blinkVideo.length;
        
        finishedBlinking = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = blinkVideo.time;
        if (currentTime >= blinkVideoLength)
        {
            print("time Over");
            finishedBlinking = true;
        }
    }

    private void OnMouseDown()
    {
        print("Mouse Down");
        if (!finishedBlinking)
        {
            CameraForward.SetActive(true);
            CameraBackwards.SetActive(false);
            
            blinkVideo.playbackSpeed = 1;
          


        }
        else
        {
            
        }

        
    }

    private void OnMouseUp()
    {
        print("Mouse Up");
        if (finishedBlinking)
        {
            CameraForward.SetActive(false);
            CameraBackwards.SetActive(true);

            blinkVideoReverse.playbackSpeed = 1; 
            // after a little bit of time trigger a scene change
            // also make the unblink part happen rather quickly

        }
        else
        {
            blinkVideoReverse.playbackSpeed = 0;
            blinkVideo.playbackSpeed = 0; 
        }
    }
}
