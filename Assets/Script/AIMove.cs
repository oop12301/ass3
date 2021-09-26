using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform[] points;
    public int index;
    public Transform target;

    public float moveSpeed;
    private Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
            gettarget();

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3 .Distance (transform .position ,target .position) < 0.1f)
        {
            gettarget();
        }
        transform.Translate(dir * Time.deltaTime * moveSpeed);
    }
    void gettarget()
    {
        if(index >= points .Length -1)
        {
            index = 0;
        }else
        {

            index++;
        }
        target = points[index];
        dir = target.position - transform.position;
    }
}
