using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform target;

    private void Update()
    {
        GetComponent<Transform>().position = target.position;
    }
}
