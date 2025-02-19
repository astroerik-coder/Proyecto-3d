using UnityEngine;


public class Huir : MonoBehaviour{
    public Transform objetivo;
    public float y = 0, x = 0, z = 0;
    private float velocidad=5;

    void Start(){y = transform.position.y;}

    void Update(){
        x = transform.position.x;
        z = transform.position.z;

        if (objetivo.position.x > x){
            x -= velocidad * Time.deltaTime;
        }
        if (objetivo.position.x < x){
            x += velocidad * Time.deltaTime;
        }
        if (objetivo.position.z > z){
            z -= velocidad * Time.deltaTime;
        }
        if (objetivo.position.z < z){
            z += velocidad * Time.deltaTime;
        }
        transform.position = new Vector3(x, y, z);
    }
}