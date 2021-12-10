using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(PlayableDirector))]
public class TimelineActivator : MonoBehaviour
{
    private PlayableDirector playableDirector;

    [SerializeField, Min(0)]
    private float skipTime = 0;

    private void Awake()
    {
        playableDirector = GetComponent<PlayableDirector>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && playableDirector.state != PlayState.Playing)
        {
            playableDirector.Play();
            playableDirector.time = skipTime;
        }
    }
}
