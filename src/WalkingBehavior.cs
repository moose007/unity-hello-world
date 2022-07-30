using UnityEngine;

public class WalkingBehavior : MonoBehaviour
{

    public Rigidbody rigidbody;

    // Update is called once per frame
    void FixedUpdate()
    {
        float perKeyMove = 1000 * Time.deltaTime;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(x: 0, y: 0, z: perKeyMove);
        }
        else if (Input.GetKey(KeyCode.DownArrow)){ 
            rigidbody.AddForce(x: 0, y: 0, z: -perKeyMove);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(x: -perKeyMove, y: 0, z: 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(x: perKeyMove, y: 0, z: 0 );
        }
        else
        {

        }
            
    }
}

