using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Video;
using UnityEngine.Audio;
using System.Collections;

public class FloorTarget1 : MonoBehaviour
{
    // public AudioMixer Mixer;
    // public AudioMixerSnapshot[] Snapshots;
    //private float[] weights = new float[5];
    private raindropMixer Mixer;
    
    public int volume;

    [SerializeField]
    private GameObject VisualObject;
    
    [SerializeField]
    private AudioSource AudioSource;

    [SerializeField]
    private GameObject black;

    [SerializeField]
    private GameObject white;

    [SerializeField]
    private GameObject[] walls;

    [SerializeField]
    private GameObject nextRaindrop;

    private RainSound rainSound;
    private GameObject raindrops;
    private bool addNew=true;

    public void Start()
    {
        // the audio source starts to loop at the beginning, but the volume is set to 0
        //bool Soundplay = false;
        //AudioSource.loop = true;
        //
        Mixer = GameObject.FindObjectOfType<raindropMixer>();
        rainSound = GameObject.Find("RainSound").GetComponent<RainSound>();
        volume = Mixer.soundVolume;

    }

    /*public FloorTarget(GameObject visualObject, TextMeshPro stepNumberText)
    {
        VisualObject = visualObject;
        //StepNumberText = stepNumberText;
    }*/

    // public void OnTriggerStay(Collider other)
    // {
        
    //     //if the ball enters 
    //     if (other.gameObject.CompareTag("Ball"))
    //     {
            //set the volume to 1
            //the sound isn't paused when the ball leaves, it's just mute
            //AudioSource.volume = 3f;
            // get the position of the ball
            //Transform ballTransform = other.transform;
            //float ballY = ballTransform.position.y;
            // the pitch of the audio source is set according to the height of the ball
            //AudioSource.pitch = 0.3f + 0.3f * ballY;
            //Debug.Log(AudioSource.pitch);
    //     }
    // }

    public void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("Ball") )
        {
            if(addNew)
            {
            volume = volume+1;
            Mixer.UpdateVolume(volume);
            addNew=false;
            }
            //
            
            /*white.SetActive(true);

            foreach(GameObject wall in walls)
            {
                wall.SetActive(true);
            }*/

            if (nextRaindrop != null)
            {
                if (!nextRaindrop.activeSelf)
                {
                    nextRaindrop.SetActive(true);
                    //rainSound.rain.volume = 0f;
                    //rainSound.rainVolume = rainSound.rainVolume - 0.33f;
                    //Debug.Log(rainSound.rainVolume);
                }
            }
            // else
            // {
            //     foreach (GameObject wall in walls)
            //     {
            //         wall.SetActive(true);
            //     }

            //     raindrops.SetActive(false);

            //     rainSound.rainVolume = rainSound.rainVolume - 0.34f;
            //     Debug.Log(rainSound.rainVolume);
            // }
        }

    }
   
    // private void OnTriggerExit(Collider other)
    // {
    //     // if the ball leaves, mute the sound
    //     if (other.gameObject.CompareTag("Ball"))
    //     {
    //         //AudioSource.volume = 0;
    //     }

    //     /*white.SetActive(false);

    //     foreach (GameObject wall in walls)
    //     {
    //         wall.SetActive(false);
    //     }*/
    // }

}
