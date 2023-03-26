using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Sprites;

public class controlVideo : MonoBehaviour {
    public VideoPlayer videoPlayer;
    public Button pauseButton;
    public Sprite spirtePause;
    public Sprite spirteStart;

    void Start()
    {
        videoPlayer.Play();
        pauseButton.onClick.AddListener(PauseResume);
    }

    void PauseResume(){
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            pauseButton.image.sprite = spirteStart;
        }
        else{
            videoPlayer.Play();
            pauseButton.image.sprite = spirtePause;
        }
    }
}