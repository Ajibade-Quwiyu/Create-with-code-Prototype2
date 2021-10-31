using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward1 : MonoBehaviour
{
    public float speed = 40.0f;
    private float bound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > bound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < -bound)
        {
            Debug.Log("Game Over !");
            Destroy(gameObject);
        }
    }
}
