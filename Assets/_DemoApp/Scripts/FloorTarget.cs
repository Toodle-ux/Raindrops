using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class FloorTarget : MonoBehaviour
{
    [SerializeField]
    private GameObject VisualObject;
    [SerializeField]
    private TextMeshPro StepNumberText;
    [SerializeField]
    private AudioSource AudioSource;

    private int _timesHit;

    private void Start()
    {
        // the audio source starts to loop at the beginning, but the volume is set to 0
        AudioSource.Play();
        AudioSource.volume = 0;
        AudioSource.loop = true;
    }

    public FloorTarget(GameObject visualObject, TextMeshPro stepNumberText)
    {
        VisualObject = visualObject;
        StepNumberText = stepNumberText;
    }

    /*private void OnTriggerEnter(Collider other)
    {
        // only be triggered by an object tagged as "Ball"
        if (other.gameObject.CompareTag("Ball"))
        {
            AudioSource.volume = 1f;
            Transform ballTransform = other.transform;
            float ballY = ballTransform.position.y;
            Debug.Log("ballY"+ballY);
            //AudioSource.pitch = 0.3f + ballY;
            AudioSource.pitch = (Random.Range(0.3f,1.2f));
            Debug.Log("pitch"+AudioSource.pitch);
        }
    }*/

    private void OnTriggerStay(Collider other)
    {
        //if the ball enters 
        if (other.gameObject.CompareTag("Ball"))
        {
            //set the volume to 1
            //the sound isn't paused when the ball leaves, it's just muted
            AudioSource.volume = 1f;

            // get the position of the ball
            Transform ballTransform = other.transform;
            float ballY = ballTransform.position.y;

            // the pitch of the audio source is set according to the height of the ball
            AudioSource.pitch = 0.3f + 0.3f * ballY;

            Debug.Log(AudioSource.pitch);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // if the ball leaves, mute the sound
        if (other.gameObject.CompareTag("Ball"))
        {
            AudioSource.volume = 0;
        }
    }

    public void Hit()
    {
        //PositiveFeedback();
        AudioSource.volume = 1f;
        AudioSource.pitch = (Random.Range(0.6f, 1.2f));

    }

    public void PositiveFeedback()
    {
        _timesHit++;

        // change color
        var col = Random.ColorHSV(0, 1, 0.5f, 1, 1, 1);
        VisualObject.GetComponent<MeshRenderer>().material.color = col;

        // update text
        StepNumberText.text = _timesHit.ToString("D2");

        // make a sound
        AudioSource.pitch = (Random.Range(0.6f, 1.2f));
        AudioSource.Play();
    }
}
