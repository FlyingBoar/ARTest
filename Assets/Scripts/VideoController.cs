using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {

    private bool _isRendered;

    public bool IsRendered
    {
        get { return _isRendered; }
        set
        {
            if(_isRendered != value)
            {
                _isRendered = value;
                ToggleVideo(IsRendered);
            }
        }
    }


    MeshRenderer rend;
    VideoPlayer videoCtrl;

	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        videoCtrl = GetComponent<VideoPlayer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rend.isVisible)
            IsRendered = true;
        else
            IsRendered = false;
    }

    void ToggleVideo(bool _active)
    {
        if (_active)
            videoCtrl.Play();
        else
            videoCtrl.Pause();
    }
}
