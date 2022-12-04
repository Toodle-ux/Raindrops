using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;
using UnityEngine.Video;
using UnityEngine.Audio;


public class ChimeSounds : MonoBehaviour
{
    public GameObject _ObjectToSpawn;
    GameObject[] _FFTGameObjects;
    public float _Spacing = 1;
    AudioSource m_MyAudioSource;
    string FileNumber;

    // Start is called before the first frame update
    void Start()
    {
        _FFTGameObjects = new GameObject[5];
        float angleSpacing = (2f * Mathf.PI) / 5;
         for (int i = 0; i <5; i++)
            {
                float angle = i * angleSpacing;
                float x = Mathf.Sin(angle) * _Spacing;
                float z = Mathf.Cos(angle) * _Spacing;

                GameObject newFFTObject = Instantiate(_ObjectToSpawn);
                newFFTObject.transform.SetParent(transform);
                newFFTObject.transform.localPosition = new Vector3(x, 0, z);


                // //---   ROTATION
                // newFFTObject.transform.LookAt(transform.position);
                // newFFTObject.transform.localRotation *= Quaternion.Euler(-90, 0, 0);

                _FFTGameObjects[i] = newFFTObject;
            }
        
            
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
