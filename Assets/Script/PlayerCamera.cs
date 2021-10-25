using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    private Transform cameraTransform { get; set; } = null;


    public float _borderSize = 10;
    public float borderSize { get { return _borderSize; } }


    public float _camSpeed = 10;
    public float camSpeed { get { return _camSpeed; } }

    void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }



    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 direction = Vector3.zero;

        if (mousePosition.x <= borderSize || Input.GetAxis("Horizontal")< 0)
        {
            direction += Vector3.left;
        }
        else if (mousePosition.x >= Screen.width - borderSize || Input.GetAxis("Horizontal") > 0)
        {
            direction += Vector3.right;
        }

        if (mousePosition.y <= borderSize || Input.GetAxis("Vertical") < 0)
        {
            direction += Vector3.back;
        }
        else if (mousePosition.y >= Screen.height - borderSize || Input.GetAxis("Vertical") > 0)
        {
            direction += Vector3.forward;
        }
        cameraTransform.position += direction.normalized * Time.deltaTime * camSpeed;
        
    }
}