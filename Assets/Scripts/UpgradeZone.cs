using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeZone : MonoBehaviour
{
    public static bool goal; // �� �ȿ� ���Դ��� ����
    public GameObject zone;

    public GameObject image;

    // Start is called before the first frame update
    void Update()
    {
        goal = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal = true;
            if(goal == true)
            {
                print("goal: " + goal);
                Destroy(zone);

                image.SetActive(true);
                PlayerShooter playerShooter = other.GetComponent<PlayerShooter>();
                playerShooter.gun.magAmmo += 100;
                playerShooter.gun.timeBetFire /= 2;
            }
            
        }
    }
}
