using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripScene2 : MonoBehaviour
{
    float x, y, z;
    public Vector3 currentEulerAngles;
    public Quaternion currentRotation;
    public float rotSpeed;
    public Transform targetA;
    public Transform targetB;
    float timeCount;
    
    void Start()
    {

    }

    void Update()
    {
        RotateInput();
        QauternionRotateTowards();
        SlerpExample();
        LookRotation();
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 48;

        GUI.Label(new Rect(10, 0, 0, 0), "rotating on X: " + x + " Y: " + y + " Z: " + z, style);
        GUI.Label(new Rect(10, 35, 0, 0), "CurrentEulerAngles:" + currentEulerAngles, style);
        GUI.Label(new Rect(10,100,0,0), "World Euler Angles: "+ transform.eulerAngles, style);
    }

    void RotateInput()
    {
        if (Input.GetKeyDown(KeyCode.X)) { x = 1 - x; }
        if (Input.GetKeyDown(KeyCode.Y)) { y = 1 - y; }
        if (Input.GetKeyDown(KeyCode.Z)) { z = 1 - z; }

        currentEulerAngles += new Vector3(x, y, z) * Time.deltaTime * rotSpeed;
        currentRotation.eulerAngles = currentEulerAngles;
        transform.rotation = currentRotation;
    }

    void QauternionRotateTowards()
    {
        float step = rotSpeed * Time.time;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetA.rotation, step);
    }

    void SlerpExample()
    {
        transform.rotation = Quaternion.Slerp(targetA.rotation, targetB.rotation,timeCount);
        timeCount = timeCount + Time.deltaTime;
    }

    void LookRotation()
    {
        Vector3 relativePos = targetA.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        transform.rotation = rotation;
    }
 
}

