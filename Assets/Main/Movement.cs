using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Animator m_animator;
    private GameObject m_player;
    private int m_speed = 100;
    private GameObject m_interact;

    private Animator m_anim;

    private float x_axis;
    private float y_axis;
    private float z_axis;

    // Start is called before the first frame update
    void Start()
    {
        m_anim= GetComponent<Animator>();

        m_anim.Play("Base Layer.Hurricane Kick", 0, 0.25f);

        m_player = GameObject.Find("Player");
        m_animator = gameObject.GetComponent<Animator>();
        m_interact = GameObject.Find("Interaction");
        m_interact.SetActive(false);
        Debug.Log(Physics.gravity);

        x_axis = 0;
        y_axis = 0;
        z_axis = 0;
    }   

    // Update is called once per frame
    void Update()
    {
        gravity();
        moves();
    }

    public void gravity()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(x_axis,y_axis-100,z_axis);
    }

    public void moves()
    {
        Vector3 tempVect = m_player.transform.transform.forward + new Vector3(x_axis, y_axis, z_axis);
        tempVect = tempVect.normalized * m_speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            //GetComponent<Rigidbody>().AddForce(tempVect, ForceMode.VelocityChange);
            GetComponent<Rigidbody>().velocity = tempVect*150;

        }
        else if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;

        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            //GetComponent<Rigidbody>().AddForce(-tempVect, ForceMode.VelocityChange);
            GetComponent<Rigidbody>().velocity = -(tempVect * 150);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up, -1);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up, 1);
        }
    }
}
