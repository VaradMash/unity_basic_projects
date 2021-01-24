using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerRotation : MonoBehaviour
{
    public float rotation_speed = 15.0f;
    public float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        Vector3 rotation_vector = new Vector3(0,0,1);
        transform.Rotate(rotation_vector * rotation_speed);
    }
}
