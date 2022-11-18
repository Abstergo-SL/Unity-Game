using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{


    private GameObject m_door;
    private BoxCollider m_boxCollider;
    private bool _isOpen;
    private bool _canOpen;
    // Start is called before the first frame update
    void Start()
    {
        m_door = GameObject.Find("Door");
        m_boxCollider = m_door.GetComponent<BoxCollider>();
        _canOpen = false;
        _isOpen= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_canOpen && Input.GetKeyDown(KeyCode.E) && !_isOpen)
        {
            Debug.Log("Abriendo puerta");
            OpenDoor();
        }
        else if (_canOpen && Input.GetKeyDown(KeyCode.E) && _isOpen)
        {
            Debug.Log("Cerrando puerta");
            CloseDoor();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            _canOpen = true;
        }
    }


    public void OpenDoor()
    {
        m_door.transform.Rotate(Vector3.back, 90);
        m_boxCollider.isTrigger = true;
        _isOpen = true;

    }
    public void CloseDoor()
    {
        m_door.transform.Rotate(Vector3.back, -90);
        m_boxCollider.isTrigger = false;
        _isOpen = false;
    }
}
