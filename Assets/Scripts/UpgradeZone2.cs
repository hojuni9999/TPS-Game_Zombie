using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeZone2 : MonoBehaviour
{
    public static bool goal2; // ��2 �ȿ� ���Դ��� ����
    public GameObject zone;

    public GameObject image;
    // Start is called before the first frame update
    void Update()
    {
        goal2 = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            goal2 = true;
            if (goal2 == true)
            {
                print("goal: " + goal2);
                Destroy(zone);

                image.SetActive(true);
                PlayerMovement playermovement = other.GetComponent<PlayerMovement>();
                playermovement.moveSpeed *= 2;
            }

        }
    }
}
