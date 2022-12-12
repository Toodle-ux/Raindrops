using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.Video;
using UnityEngine.Audio;
using System.Collections;
public class raindropMixer : MonoBehaviour
{
     private float[] weights = new float[5];
     public AudioMixer Mixer;
     public AudioMixerSnapshot[] Snapshots;
     public int soundVolume = 0;
     public FloorTarget Target ;
     public int CaseNumber;
    
     
    // Start is called before the first frame update
    public void UpdateVolume(int volume)
    {
        soundVolume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(soundVolume);
        
        switch(soundVolume)
            {
            case 1:
                weights[0] = 1.0f;
                weights[1] = 0.0f;
                weights[2] = 0.0f;
                weights[3] = 0.0f;
                weights[4] = 0.0f;
                Mixer.TransitionToSnapshots(Snapshots, weights, 1f);
                break;
            case 2:
                weights[0] = 0.0f;
                weights[1] = 1.0f;
                weights[2] = 0.0f;
                weights[3] = 0.0f;
                weights[4] = 0.0f;
                Mixer.TransitionToSnapshots(Snapshots, weights, 1f);
                break;
            case 3:
                weights[0] = 0.0f;
                weights[1] = 0.0f;
                weights[2] = 1.0f;
                weights[3] = 0.0f;
                weights[4] = 0.0f;
                Mixer.TransitionToSnapshots(Snapshots, weights, 1f);
                break;
            case 4:
                weights[0] = 0.0f;
                weights[1] = 0.0f;
                weights[2] = 0.0f;
                weights[3] = 1.0f;
                weights[4] = 0.0f;
                Mixer.TransitionToSnapshots(Snapshots, weights, 1f);
                break;  
            case 5:
                weights[0] = 0.0f;
                weights[1] = 0.0f;
                weights[2] = 0.0f;
                weights[3] = 0.0f;
                weights[4] = 1.0f;
                Mixer.TransitionToSnapshots(Snapshots, weights, 1f);
                break;  

            }
        
    }
}
