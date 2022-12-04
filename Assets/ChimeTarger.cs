using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimeTarger : MonoBehaviour
{
    public AudioSource audioSource;
    public int midiNote;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            audioSource.Play();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
