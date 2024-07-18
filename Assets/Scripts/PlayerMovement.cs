using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rd;

    public float forwardForce ;
    public float sidewaysForce ;

    // Update is called once per frame
    void FixedUpdate()
    {
        rd.AddForce( 0 , 0, forwardForce * Time.fixedDeltaTime);

        if (Input.GetKey("a"))
        {
            rd.AddForce(-sidewaysForce * Time.fixedDeltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rd.AddForce(sidewaysForce * Time.fixedDeltaTime, 0, 0, ForceMode.VelocityChange);
        }
/*        if (Input.GetKey("w"))
        {
            rd.AddForce(0, 0, forwardForce * Time.fixedDeltaTime);
        }
        if (Input.GetKey("s"))
        {
            rd.AddForce(0, 0, -forwardForce * Time.fixedDeltaTime);
        }*/

        if(rd.position.y < -2f)
        {
            enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }

    }



}
