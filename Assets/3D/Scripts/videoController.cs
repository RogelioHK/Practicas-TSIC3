using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;


/// <summary>
/// Controls target objects behaviour.
/// </summary>
public class videoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button pauseButton;
    public Sprite spirtePause;
    public Sprite spirteStart;
    //public string SceneName;

    // The objects are about 1 meter in radius, so the min/max target distance are
    // set so that the objects are always within the room (which is about 5 meters
    // across).
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;


    void Start()
    {
        videoPlayer.Play();
        pauseButton.onClick.AddListener(PauseResume);
    }

    /// <summary>
    /// Teleports this instance randomly when triggered by a pointer click.
    /// </summary>
    /*public void TeleportRandomly()
    {
        // Picks a random sibling, activates it and deactivates itself.
        int sibIdx = transform.GetSiblingIndex();
        int numSibs = transform.parent.childCount;
        sibIdx = (sibIdx + Random.Range(1, numSibs)) % numSibs;
        GameObject randomSib = transform.parent.GetChild(sibIdx).gameObject;

        // Computes new object's location.
        //float angle = Random.Range(-Mathf.PI, Mathf.PI);
        //float distance = Random.Range(_minObjectDistance, _maxObjectDistance);
        //float height = Random.Range(_minObjectHeight, _maxObjectHeight);
        //Vector3 newPos = new Vector3(Mathf.Cos(angle) * distance, height,
                                     Mathf.Sin(angle) * distance);

        // Moves the parent to the new position (siblings relative distance from their parent is 0).
        //transform.parent.localPosition = newPos;

        //randomSib.SetActive(true);
        //gameObject.SetActive(false);
        //SetMaterial(false);
    }*/

    /// <summary>
    /// This method is called by the Main Camera when it starts gazing at this GameObject.
    /// </summary>
    public void OnPointerEnter()
    {
        //SetMaterial(true);
        //Debug.Log("A la vista");
        PauseResume();
        //LoadNewScene();
    }


    /// <summary>
    /// This method is called by the Main Camera when it stops gazing at this GameObject.
    /// </summary>
    public void OnPointerExit()
    {
        Debug.Log("Fuera de vista");
        //SetMaterial(false);
    }

    void PauseResume()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
            pauseButton.image.sprite = spirteStart;
        }
        else
        {
            videoPlayer.Play();
            pauseButton.image.sprite = spirtePause;
        }
    }
}
