using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47 : MonoBehaviour, IItem
{
    public void Use(GameObject target)
    {
        // 전달 받은 게임 오브젝트로부터 PlayerShooter 컴포넌트를 가져오기 시도
        PlayerShooter playerShooter = target.GetComponent<PlayerShooter>();
        Gun gun = target.GetComponent<Gun>();

        // PlayerShooter 컴포넌트가 있으며, 총 오브젝트가 존재하면
        

        // 사용되었으므로, 자신을 파괴
        Destroy(gameObject);
    }
}
