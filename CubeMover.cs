using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float transformTime = 2.0f;
    public GameObject target = null;
    private float movspeed;
    private float rotspeed;

    private void Start()
    {
        movspeed = Vector3.Distance(this.transform.position, target.transform.position) / transformTime;
        rotspeed = Quaternion.Angle(this.transform.rotation, target.transform.rotation) / transformTime;
    }

    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, target.transform.position, movspeed * Time.deltaTime);
        this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, target.transform.rotation, rotspeed * Time.deltaTime);
    }
}