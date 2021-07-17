using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed=10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x*Vector3.right*Time.deltaTime*moveSpeed,Space.World);
        transform.Translate(y*Vector3.forward*Time.deltaTime*moveSpeed,Space.World);
    }
}
