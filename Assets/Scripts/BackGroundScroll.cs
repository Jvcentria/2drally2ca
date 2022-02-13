using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector3.left * speed * Time.deltaTime);//down
        if (transform.position.y < -14.26f)
        {
            transform.position = StartPosition;
        }
    }
}
