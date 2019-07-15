using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNPC : MonoBehaviour
{
    private Rigidbody2D rbd;
    public float velocidade;
    private float altura;
    // Start is called before the first frame update
    void Start()
    {
        altura = Camera.main.orthographicSize;
        velocidade = 5;
        rbd = this.GetComponent<Rigidbody2D>();
        rbd.velocity = new Vector2(0,-1*velocidade);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Projetil")
        {
            //Incremente o placar
            //Debug.Log("Um tiro me acertou e eu sou o vilão!!!");
            //Trazer para este código, o gameObject do placar
            //GameObject meuplacar = GameObject.Find("ScoreController");
            //Pegar, do gameobject, o script do placar
            //scriptScore script = meuplacar.GetComponent<scriptScore>();
            //Incrementar o placar
            //script.addScore(10);
            scriptScore.addScore(10);
            Destroy(col.gameObject);
        }
        else
        {
            //Reduza a vida do PC
            scriptPC script = col.GetComponent<scriptPC>();
            script.subtractLife(1);

        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -altura-1)
            Destroy(this.gameObject);
    }
}
