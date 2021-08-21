
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;


    public float forwardForse = 1000f;
    public float sideForse = 500f;
    public float goFaster = 1f;
  

    // Update is called once per frame
    void FixedUpdate()
    {
        goFaster += 0.01f;
        rb.AddForce(0,0, forwardForse * Time.deltaTime*goFaster);

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
