using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupInstantiator : MonoBehaviour

{
    public GameObject myPrefabPickupObject = null;
    // Start is called before the first frame update
    void Start()
    {
        GameObject pointbox1 = Instantiate(
            myPrefabPickupObject,
            new Vector3(-4.18f, -6.31f, 8.67f),
            Quaternion.identity
            );
        pointbox1.GetComponent<Renderer>().material.color = Color.gray;
        pointbox1.GetComponent<PickupPoints>().Points = 1;
        GameObject pointbox2 = Instantiate(
            myPrefabPickupObject,
            new Vector3(-1.68f, -6.31f, 5.81f),
            Quaternion.identity
            );
        pointbox2.GetComponent<Renderer>().material.color = Color.cyan;
        pointbox2.GetComponent<PickupPoints>().Points = 2;
        GameObject pointbox3 = Instantiate(
           myPrefabPickupObject,
           new Vector3(2.45f, -6.31f, 6.16f),
           Quaternion.identity
           );
        pointbox3.GetComponent<Renderer>().material.color = Color.yellow;
        pointbox3.GetComponent<PickupPoints>().Points = 3;
        GameObject pointbox4 = Instantiate(
           myPrefabPickupObject,
           new Vector3(4.83f, -6.31f, 8.36f),
           Quaternion.identity
           );
        pointbox4.GetComponent<Renderer>().material.color = Color.gray;
        pointbox4.GetComponent<PickupPoints>().Points = 1;
        GameObject pointbox5 = Instantiate(
           myPrefabPickupObject,
           new Vector3(3.02f, -6.31f, 14.68f),
           Quaternion.identity
           );
        pointbox5.GetComponent<Renderer>().material.color = Color.gray;
        pointbox5.GetComponent<PickupPoints>().Points = 1;
        GameObject pointbox6 = Instantiate(
           myPrefabPickupObject,
           new Vector3(4.82f, -6.31f, 12.01f),
           Quaternion.identity
           );
        pointbox6.GetComponent<Renderer>().material.color = Color.cyan;
        pointbox6.GetComponent<PickupPoints>().Points = 2;
        GameObject pointbox7 = Instantiate(
           myPrefabPickupObject,
           new Vector3(-1.07f, -6.31f, 15.16f),
           Quaternion.identity
           );
        pointbox7.GetComponent<Renderer>().material.color = Color.yellow;
        pointbox7.GetComponent<PickupPoints>().Points = 3;
        GameObject pointbox8 = Instantiate(
           myPrefabPickupObject,
           new Vector3(-4.41f, -6.31f, 12.74f),
           Quaternion.identity
           );
        pointbox8.GetComponent<Renderer>().material.color = Color.cyan;
        pointbox8.GetComponent<PickupPoints>().Points = 2;
    }
}
