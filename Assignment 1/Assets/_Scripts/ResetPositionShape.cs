using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionShape : MonoBehaviour
{
    Vector3 originalPositionValue;
    public Quaternion originalRotationalValue;
    // Start is called before the first frame update
    void Start()
    {
        originalPositionValue = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalRotationalValue = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            gameObject.transform.position = originalPositionValue;
            gameObject.transform.rotation = originalRotationalValue;
        }

    }
}