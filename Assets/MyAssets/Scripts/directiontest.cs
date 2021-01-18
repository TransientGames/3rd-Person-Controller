using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class directiontest : MonoBehaviour
{
    public GameObject cube;
    void Start()
    {
        transform.eulerAngles = cube.transform.eulerAngles;
        print("capsule rotation: " + transform.rotation + " capsule localrotation: " + transform.localRotation + " capsule euler angles: " + transform.eulerAngles + " capsule local euler angles " + transform.localEulerAngles);
        print("cube rotation: " + cube.transform.rotation + " cube localrotation: " + cube.transform.localRotation + " cube euler angles: " + cube.transform.eulerAngles + " cube local euler angles " + cube.transform.localEulerAngles);
    }
}
