
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;


    public float forwardForse = 2000f;
    public float sideForse = 500f;
  

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0, forwardForse * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rb.AddForce(sideForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       

    }
}
