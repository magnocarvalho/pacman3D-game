using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTiro : MonoBehaviour
{
    public float velocidade;
    private Rigidbody2D rbd;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        velocidade = 10; 
        rbd.velocity = new Vector2(0, velocidade);

    }

    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > Camera.main.orthographicSize + 1)
            Destroy(this.gameObject);
    }
}
