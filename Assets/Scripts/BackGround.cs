using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    Vector3 startpos;
    public GameObject cam;
    public float Effect;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = (cam.transform.position * Effect + startpos);

        transform.position = distance;
    }
}
