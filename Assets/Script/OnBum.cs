using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBum : MonoBehaviour
{
    // Start is called before the first frame update
    private int hits = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.tag = "Hit";
            Debug.Log("On Bum!!");
            GetComponent<MeshRenderer>().material.color = Color.red;
            hits++;
            Debug.Log(hits);
        }
    }

}
