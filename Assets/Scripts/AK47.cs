using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47 : MonoBehaviour, IItem
{
    public void Use(GameObject target)
    {
        // ���� ���� ���� ������Ʈ�κ��� PlayerShooter ������Ʈ�� �������� �õ�
        PlayerShooter playerShooter = target.GetComponent<PlayerShooter>();
        Gun gun = target.GetComponent<Gun>();

        // PlayerShooter ������Ʈ�� ������, �� ������Ʈ�� �����ϸ�
        

        // ���Ǿ����Ƿ�, �ڽ��� �ı�
        Destroy(gameObject);
    }
}
