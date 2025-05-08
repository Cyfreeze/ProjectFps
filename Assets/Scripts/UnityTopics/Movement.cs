using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody _rb;
    private bool _isGrounded = true;
    private Vector3 _movement;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    void Start()
    {

        // GameObject: General object type 
        // gameObject: Script attached object
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //_rb.velocity = _movement * 10f;
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        _movement = new Vector3(horizontalMovement, 0, verticalMovement);
        _rb.velocity = _movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {


            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("left mouse button");


        }

        if (Input.GetMouseButtonDown(1))
        {

            Debug.Log("Right mouse button");
        }

        if (Input.GetMouseButtonDown(2))
        {

            Debug.Log("middle mouse button");
        }

        if (Input.GetMouseButtonUp(0))
        {

            Debug.Log("🥶");
        }



        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.green);

        if (Physics.Raycast(ray, out hit))
        {
            // Debug.Log("Hit: " + hit.collider.name);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = true;

        }
    }

    void OnCollisionStay(Collision collision)
    {

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGrounded = false;

        }
    }
}

