﻿using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;
    private Vector3 offset;

    private void Start()
    {
        offset = GetComponent<Transform>().position - target.position;
    }

    private void Update()
    {
        GetComponent<Transform>().position = target.position + offset;
    }
}
