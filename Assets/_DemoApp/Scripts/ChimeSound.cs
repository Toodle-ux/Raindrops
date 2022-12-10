using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimeSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    private float ballX;
    private float ballY;
    private float ballZ;

    public GameObject inkStart;
    private Transform inkTransform;

    private GameObject canvas;

    public Collider2D m_moveArea;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            audioSource.Play();

            Transform ballTransform = other.transform;
            ballX= ballTransform.position.x;
            ballY= ballTransform.position.y;
            ballZ= ballTransform.position.z;


            //Instantiate(inkStart, canvas.transform);
            //Instantiate(inkStart, new Vector3(ballX, inkStart.transform.position.y, inkStart.transform.position.z), Quaternion.identity, canvas.transform);
            
            Instantiate(inkStart, new Vector3(ballX + m_moveArea.bounds.min.x, inkStart.transform.position.y, 0f),Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Front Canvas");
        Debug.Log(canvas.name);

        GameObject shipArea = GameObject.Find("ShipArea");
        m_moveArea = shipArea.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
