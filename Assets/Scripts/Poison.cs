using UnityEngine;

// 시야를 방해하는 아이템
public class Poison : MonoBehaviour, IItem
{
    public float poison = 50;

    public void Use(GameObject target)
    {
        // 전달받은 게임 오브젝트로부터 LivingEntity 컴포넌트 가져오기 시도
        LivingEntity life = target.GetComponent<LivingEntity>();
        PlayerMovement move = target.GetComponent<PlayerMovement>();

        // LivingEntity컴포넌트가 있다면
        if (life != null)
        {
            move.p.SetActive(true); // 시야 방해 공전물 활성화
            life.Slowdamage(poison);
            
        }

        // 사용되었으므로, 자신을 파괴
        Destroy(gameObject);
    }
}