using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeZone3 : MonoBehaviour
{
    public static bool goal3; // 존 안에 들어왔는지 여부
    public GameObject zone;

    public GameObject image;
    // Start is called before the first frame update
    void Update()
    {
        goal3 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal3 = true;
            if (goal3 == true)
            {
                print("goal: " + goal3);
                Destroy(zone);

                image.SetActive(true);
                PlayerShooter playerShooter = other.GetComponent<PlayerShooter>();
                playerShooter.gun.damage *= 2;
            }

        }
    }
}
