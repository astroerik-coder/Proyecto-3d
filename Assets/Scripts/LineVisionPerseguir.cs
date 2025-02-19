using UnityEngine;


public class LineVisionPerseguir : MonoBehaviour
{
    public Transform objetivo;
    public float y = 0, x = 0, z = 0;
    private float velocidad=5;

    void Start()
    {
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objetivo);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}