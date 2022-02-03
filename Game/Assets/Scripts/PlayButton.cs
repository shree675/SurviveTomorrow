using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour{

    public UnityEngine.Video.VideoPlayer videoPlayer;
    public static bool played=false;
    public RawImage rawImage;
    [SerializeField] Text text;
    [SerializeField] Text text2;

    void Start(){
        rawImage.enabled = true;
        played=false;
        text.enabled=true;
        text.gameObject.SetActive(true);
        text2.enabled=true;
        text2.gameObject.SetActive(true);
    }

    public void OnClick(){
        videoPlayer.Play();
        played=true;
        rawImage.enabled=false;
        text.gameObject.SetActive(false);
        text2.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }
}
