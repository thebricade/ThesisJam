using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayReverse : MonoBehaviour
{
    public GameObject VideoTrial, VideoTrialBackwards;
    public GameObject CameraForward, CameraBackwards; 
    private VideoPlayer trainVideo, trainVideoBackwards;

    private bool playingForward; 
    // Start is called before the first frame update
    void Start()
    {
        trainVideo = VideoTrial.GetComponent<VideoPlayer>();
        trainVideoBackwards = VideoTrialBackwards.GetComponent<VideoPlayer>();
        trainVideo.time = 1;
        trainVideoBackwards.time = 1; 
        playingForward = true;
        print(trainVideoBackwards.length);

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnMouseEnter()
    {
        if (playingForward)
        {
            CameraForward.SetActive(true);
            CameraBackwards.SetActive(false);
            trainVideo.playbackSpeed = 1;
        }
        else
        {
            CameraForward.SetActive(false);
            CameraBackwards.SetActive(true);
             
            trainVideoBackwards.playbackSpeed = 1; 

        }
    }

    private void OnMouseExit()
    {
        if (playingForward)
        {
            trainVideo.playbackSpeed = 0;
            trainVideoBackwards.playbackSpeed = 0; 
            trainVideoBackwards.time = trainVideoBackwards.length -trainVideo.time;
            playingForward = false;
        }
        else
        {
            trainVideoBackwards.playbackSpeed = 0; 
            trainVideo.playbackSpeed = 0;
            //trainVideo.time = trainVideo.length - trainVideoBackwards.time;
            //playingForward = true;
        }
               
        //VideoTrial.SetActive(false);
        //VideoTrialBackwards.SetActive(true);
        //trainVideoBackwards.timeSource = trainVideo.time-trainVideoBackwards.length; 


    }
}
