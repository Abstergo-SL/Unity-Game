using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    private Animator m_animator;
    private CharacterController m_characterController;
    private GameObject m_player;
    private GameObject m_interact;

    public float sensitivity = 0.000000001f;

    public float m_speed = 6.0F;
    public float jumpSpeed = 10.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    private Animator m_anim;

    private float x_axis;
    private float y_axis;
    private float z_axis;

    // Start is called before the first frame update
    void Start()
    {
        m_anim= GetComponent<Animator>();
        m_characterController= GetComponent<CharacterController>();
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
        moves();
        rotation();
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }

    public void rotation()
    {
        //var c = Camera.main.transform;
        var c = m_player.transform;
        c.Rotate(0, Input.GetAxis("Mouse X")/2 * sensitivity, 0);
        //c.Rotate(-Input.GetAxis("Mouse Y") * sensitivity, 0, 0);
        if (Input.GetMouseButtonDown(0))
            UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }
    public void moves()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= m_speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed * 3;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
