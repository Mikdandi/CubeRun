
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody rb;


    public float forwardForse = 1000f;
    public float sideForse = 500f;
    public float goFaster = 1f;
    public float deltaSpeed = 0.01f;
    public bool isStart = false;
  

    // Update is called once per frame
    void FixedUpdate()
    {

        /*якщо я хочу щоб гра починалась коли я натискаю пробіл мені цей іф краще написати в старті, чи можна залишити в апдейт.
         Хотів ще запитати якщо в нас є частина коду, яка є, але вона не викликається, потипу як те що ми чекаємо пробілу, щоб почати гру
         вона займає місце, сповільнює роботу програми?*/
        if (Input.GetKey("Space"))
        {
            isStart = true;
        }

        if (isStart)
        {

            goFaster += deltaSpeed;
            
            //??
            rb.AddForce(0, 0, forwardForse * Time.deltaTime * goFaster);
         //   rb.velocity=Vector3.

            if (Input.GetKey("d"))
            {
                rb.AddForce(sideForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sideForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

        }

    }
}
