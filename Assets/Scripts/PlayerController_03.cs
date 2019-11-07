using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_03 : MonoBehaviour
{
    //define variables(steuerung), variables consist of;
    //access modifier     data type   variable name    variable value
    //NOCH FESTLEGEN und einen private float machen
    public float speed = 25.5f;
    public float turnSpeed;
    public float horizontalInput;
    public float forwardInput;

    //Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {   //get input    siehe Dokumentation input.GetAxis, von dort einfach die Tastaturbelegung übernehmen, die horizontalen für r/l
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //turn vehicle sideways based on player input up/down
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //move vehicle forward, when arrow keys right and/or left 
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
