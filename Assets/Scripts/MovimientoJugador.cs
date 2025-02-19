using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public Transform objetivo;
    private int velAngular=60;
    private float velocidad=15;

    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            transform.Rotate(new Vector3(0,-velAngular*Time.deltaTime,0));
        }
        if(Input.GetKey(KeyCode.D)){
            transform.Rotate(new Vector3(0,velAngular*Time.deltaTime,0));
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector3(0,0,velocidad*Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Translate(new Vector3(0,0,-velocidad*Time.deltaTime));
        }
    }
}
