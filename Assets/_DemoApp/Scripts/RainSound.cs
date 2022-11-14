using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{
    public AudioSource rain;
    public float rainVolume;

    // Start is called before the first frame update
    void Start()
    {
        rain.Play();
        rain.volume = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        rain.volume = rainVolume;
    }
}
