using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMov : MonoBehaviour
{
    public CharacterController controlador;
    public Camera mainCam;
    public float velocity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        mainCam.transform.position = new Vector3 (transform.position.x, transform.position.y, -10f);
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 movimento = Vector3.Normalize(transform.up * y + transform.right * x);
        controlador.Move(movimento * velocity * Time.deltaTime);
    }
}
