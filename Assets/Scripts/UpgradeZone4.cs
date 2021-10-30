using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeZone4 : MonoBehaviour
{
    public static bool goal4; // 존 안에 들어왔는지 여부
    public GameObject zone;

    public GameObject image;
    // Start is called before the first frame update
    void Update()
    {
        goal4 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal4 = true;
            if (goal4 == true)
            {
                print("goal: " + goal4);
                Destroy(zone);

                image.SetActive(true);
                PlayerShooter playerShooter = other.GetComponent<PlayerShooter>();
                playerShooter.gun.fireDistance *= 3;
            }

        }
    }
}
