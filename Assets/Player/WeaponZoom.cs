using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] Camera fpsCamera;
[SerializeField] float zoomedoutFOV = 100f;
[SerializeField] float zoomedinFOV = 60f;
bool zoomedInToggle = false;

void Update()
{

    if (Input.GetKey(KeyCode.B))
        {
 Debug.Log("ok");
            if (zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomedinFOV;
            }
            else{
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedoutFOV;
            }
        }
}
}
