using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    Vector3 originalPositionViewLocation;
    public Quaternion originalRotationalValue;
    Vector3 BirdsEyePositionViewLocation;
    public Quaternion BirdsEyeRotationalValue;
    // Start is called before the first frame update
    void Start()
    {
        originalPositionViewLocation = new Vector3(12.4f, -9.57f, -10.35f);
        originalRotationalValue = Quaternion.Euler(24.27f, -1.795f, -1.298f);
        BirdsEyePositionViewLocation = new Vector3(12.43f, -3.25f, -3.43f);
        BirdsEyeRotationalValue = Quaternion.Euler(87.83701f, -87.791f, -86.53001f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
            {

            if (Camera.main.transform.position != originalPositionViewLocation)
            {
                Camera.main.transform.position = originalPositionViewLocation;
                Camera.main.transform.rotation = originalRotationalValue;
            }
            else
            {
                Camera.main.transform.position = BirdsEyePositionViewLocation;
                Camera.main.transform.rotation = BirdsEyeRotationalValue;
            }

        }

    }
}