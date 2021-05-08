using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBehind : MonoBehaviour
{
    private const float speedX = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * speedX;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * speedX;
        transform.Translate(xValue, 0, zValue);
    }
}
