using UnityEngine;
using System.Collections;

public class ShipPlayerController : MonoBehaviour
{
	public float m_speed = 1f;
	public float m_rotationSpeed = 1f;
    public Collider2D m_moveArea;

    private void Start()
    {
        GameObject shipArea = GameObject.Find("ShipArea");
        m_moveArea= shipArea.GetComponent<Collider2D>();
    }
    void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			gameObject.transform.Rotate(new Vector3(0f, 0f, m_rotationSpeed * Time.deltaTime));
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			gameObject.transform.Rotate(new Vector3(0f, 0f, -m_rotationSpeed * Time.deltaTime));
		}

		Vector3 dir = gameObject.transform.rotation * Vector3.right;
		gameObject.transform.position += dir * m_speed * Time.deltaTime;

        if (!m_moveArea.bounds.Contains(transform.position))
        {
            Vector3 new_pos = transform.position;
            if (transform.position.x > m_moveArea.bounds.max.x)
            {
                new_pos.x = m_moveArea.bounds.min.x;
                Debug.Log("xMax: "+ m_moveArea.bounds.max.x+
                    "\nxMin: "+m_moveArea.bounds.min.x+
                    "\nyMax: "+m_moveArea.bounds.max.y+
                    "\nyMin: "+m_moveArea.bounds.min.y);
                //Destroy(this);
                
            }
            else if (transform.position.x < m_moveArea.bounds.min.x)
            {
                new_pos.x = m_moveArea.bounds.max.x;
                Debug.Log("xMax: " + m_moveArea.bounds.max.x +
                    "\nxMin: " + m_moveArea.bounds.min.x +
                    "\nyMax: " + m_moveArea.bounds.max.y +
                    "\nyMin: " + m_moveArea.bounds.min.y);
                //Destroy(this);
            }

            if (transform.position.y > m_moveArea.bounds.max.y)
            {
                new_pos.y = m_moveArea.bounds.min.y;
                new_pos.x = Random.Range(m_moveArea.bounds.min.x, m_moveArea.bounds.max.x);
                Debug.Log("xMax: " + m_moveArea.bounds.max.x +
                    "\nxMin: " + m_moveArea.bounds.min.x +
                    "\nyMax: " + m_moveArea.bounds.max.y +
                    "\nyMin: " + m_moveArea.bounds.min.y);
                //Destroy(this);
            }
            else if (transform.position.y < m_moveArea.bounds.min.y)
            {
                new_pos.y = m_moveArea.bounds.max.y;
                new_pos.x = Random.Range(m_moveArea.bounds.min.x, m_moveArea.bounds.max.x);
                Debug.Log("xMax: " + m_moveArea.bounds.max.x +
                    "\nxMin: " + m_moveArea.bounds.min.x +
                    "\nyMax: " + m_moveArea.bounds.max.y +
                    "\nyMin: " + m_moveArea.bounds.min.y);
                //Destroy(this);
            }

            transform.position = new_pos;
        }
	}
}