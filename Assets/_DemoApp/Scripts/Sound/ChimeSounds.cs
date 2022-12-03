using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            //   AudioSource audioSource;
            // public string fileNumber[i];
            // for(int i=0; i<30; i++){
            //     string stringName =  "Aqua" + " " " + i + " " ";
            //     fileNumb
            // }

        //     string fileNumber = new FileNumber<string>();

        //         for (int i = 0; i < 9; i++)
        //         {
        //             // string pushStuff = "Aqua" + " " " + i + " " ";
        //             fileNumber.Add("hello"+i);
        //         }
        //         Debug.Log(fileNumber);
        //    m_MyAudioSource = GameObject.Find("chime").GetComponent<audioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
