using UnityEngine;

public class ControCamara : MonoBehaviour
{
    public Transform objetivo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(objetivo!=null)
       {
          transform.position = objetivo.position + new Vector3(0, 5, -10);
          transform.LookAt(objetivo);
       }
    }
}
