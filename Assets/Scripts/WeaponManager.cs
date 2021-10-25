using System.Collections;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public float switchDelay = 1f;
    public GameObject[] weapon;

    private int index = 0;
    private bool isSwitching = false;

    // Use this for initialization
    private void Start()
    {
        InitializeWeapon();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && !isSwitching)
        {
            index++;
            if (index >= weapon.Length)
                index = 0;
            StartCoroutine(SwitchDelay(index));
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && !isSwitching)
        {
            index--;
            if (index < 0)
                index = weapon.Length - 1;
            StartCoroutine(SwitchDelay(index));
        }

        // weapon switching by alphanum
        for (int i = 49; i < 58; i++)
        {
            if (Input.GetKeyDown((KeyCode)i) && !isSwitching && weapon.Length > i - 49 && index != i - 49)
            {
                index = i - 49;
                StartCoroutine(SwitchDelay(index));
            }
        }
    }

    private void InitializeWeapon()
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            weapon[i].SetActive(false);
        }
        weapon[0].SetActive(true);
        index = 0;
    }

    private IEnumerator SwitchDelay(int newIndex)
    {
        isSwitching = true;
        SwitchWeapons(newIndex);
        yield return new WaitForSeconds(switchDelay);
        isSwitching = false;
    }

    private void SwitchWeapons(int newIndex)
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            weapon[i].SetActive(false);
        }
        weapon[newIndex].SetActive(true);
    }
}