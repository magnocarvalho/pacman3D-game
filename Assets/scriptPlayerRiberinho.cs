using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayerRiberinho : MonoBehaviour
{
     public float velocidade;
    public float velRot;
    private Rigidbody rbd;
    public Animation anim;
    public   AnimationClip clip;
    private Quaternion rotOriginal;
    private float rotMX=0;    
    // Start is called before the first frame update
    void Start()
    {
        velRot = 40;
        velocidade = 5;
        rbd = GetComponent<Rigidbody>();
              
        rotOriginal = transform.localRotation;
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveL = Input.GetAxis("Horizontal");
        float moveF = Input.GetAxis("Vertical");

        rotMX += Input.GetAxis("Mouse X");
        
        Quaternion lado = Quaternion.AngleAxis(rotMX,Vector3.up);
        transform.localRotation = rotOriginal * lado ;

        rbd.velocity = transform.TransformDirection(new Vector3(moveL * velocidade, rbd.velocity.y, moveF * velocidade));


        int dir = 0;
        if (Input.GetKey(KeyCode.Q))
            dir = -1;
        else if (Input.GetKey(KeyCode.E))
            dir = 1;

        transform.Rotate(new Vector3(0,dir * velRot * Time.deltaTime,0));
       
    }
}
