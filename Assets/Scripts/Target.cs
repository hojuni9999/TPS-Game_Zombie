using System.Collections;
using UnityEngine;

// 적 AI를 구현한다
public class Target : LivingEntity
{

    public void Setup(float newHealth, float newDamage, float newSpeed, Color skinColor)
    {
        startingHealth = newHealth;     // 체력 설정
        health = newHealth;
    }
    // 데미지를 입었을때 실행할 처리
    public override void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        // LivingEntity의 OnDamage()를 실행하여 데미지 적용
        base.OnDamage(damage, hitPoint, hitNormal);
    }

    public override void Die()
    {
        // LivingEntity의 Die()를 실행하여 기본 사망 처리 실행
        base.Die();
    }
}