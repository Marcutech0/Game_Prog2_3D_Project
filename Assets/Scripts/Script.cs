using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script : MonoBehaviour
{
    public Renderer rend;
    public Color[] colors;
    public float rotatespeed;
    public float speed;
    public float time;
    public Transform pointA, pointB;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        //transform.position = Vector3.left;
        //rend.material.color = colors[1];
    }

    private void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.time);
        //transform.Rotate(Vector3.up, rotatespeed);
        transform.position = Vector3.Lerp(pointA.position, pointB.position, speed * Time.time);

    }

    private void OnEnable()
    {

    }

    /*private void OnMouseDown()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnMouseUp()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnMouseEnter()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnMouseExit()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }
     private void OnMouseDrag()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }*/
}