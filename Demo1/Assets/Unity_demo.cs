using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unity_demo : MonoBehaviour
{
    public float forwardSpeed;
    // public int score =0;

    CharacterController characterController;
    Vector3 direction;

    // add as a component to the object also

    // Start is called before the first frame update

    // public void Collect(){
    //     Score++;
    //     //text.text=Score;
    // }
    void Start()
    {
        // anything written here will be executed first

        //Debug.Log("Start");
        characterController = GetComponent<CharacterController>();
        forwardSpeed=30;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        //set the transform paramterters on the right side panel
        // decmimal values should be suffixed with f representing float

        // moves the object upwards
        // moves the object one meter per sec ' ()* Time.deltaTime '
        // // transform.Translate(new Vector3(0,1,0) * Time.deltaTime); 
        
        var forward = Input.GetAxis("Horizontal");
        var leftRight = Input.GetAxis("Vertical");

        characterController.Move(leftRight * transform.forward * Time.deltaTime * forwardSpeed);
        characterController.Move(forward * transform.right * Time.deltaTime * forwardSpeed);

        // direction.z = forwardSpeed;

    }

    // private void FixedUpdate(){
    //     characterController.Move(direction * Time.fixedDeltaTime );
        
    // }
}
