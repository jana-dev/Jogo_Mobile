using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Rigidbody2D rig;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-110, -60)));
    }

    // Update is called once per frame
    void FixedUpdate() //melhor para se trabalhar quando o objeto tem física
    {
        rig.MovePosition(transform.position + transform.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") == true)
        {
            Debug.Log("estou batendo em algo");
            GameController.instance.ShowGameOver();
        }
    }
}
