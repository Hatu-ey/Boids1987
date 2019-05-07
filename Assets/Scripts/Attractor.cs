﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour {

    static public Vector3 Pos = Vector3.zero;

    [Header("Definiowanie w panelu inspekcyjnym")]
    public float radius = 10;
    public float xPhase = 0.5f;
    public float yPhase = 0.4f;
    public float zPhase = 0.1f;


    private void FixedUpdate()
    {
        Vector3 tPos = Vector3.zero;
        Vector3 scale = transform.localScale;
        tPos.x = Mathf.Sin(xPhase * Time.time) * radius * scale.x;
        tPos.y = Mathf.Sin(yPhase * Time.time) * radius * scale.x;
        tPos.z = Mathf.Sin(zPhase * Time.time) * radius * scale.x;
        transform.position = tPos;
        Pos = tPos;

    }
}
