using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptFundo : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        velocidade = 3;
        rbd = GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0,-velocidade);
    }


    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y < -2 * Camera.main.orthographicSize)
            transform.position = new Vector2(0, 2 * Camera.main.orthographicSize);
    }
}
