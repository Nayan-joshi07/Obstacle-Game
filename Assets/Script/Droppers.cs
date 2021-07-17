using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droppers : MonoBehaviour
{
    [SerializeField] float timeToWait = 5.0f;
    private MeshRenderer mesh_Object;
    // Start is called before the first frame update
    void Start()
    {
        mesh_Object = GetComponent<MeshRenderer>();
        mesh_Object.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time >= timeToWait)
        {
            mesh_Object.enabled = true;
            GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
