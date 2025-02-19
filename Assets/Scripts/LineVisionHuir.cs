using UnityEngine;
using Vector3 = UnityEngine.Vector3;


public class LineVisionHuir : MonoBehaviour
{
    private float velocidad=5;
    public Transform objetivo;

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 punto= objetivo.position - transform.position;
        Vector3 vision= transform.position - punto;
        transform.LookAt(vision);
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
}