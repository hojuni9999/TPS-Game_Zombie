using UnityEngine;

// 게임 점수를 감소시키는 아이템
public class MCoin : MonoBehaviour, IItem
{
    public int score = 200; // 감소할 점수

    public void Use(GameObject target)
    {
        // 게임 매니저로 접근해 점수 추가
        GameManager.instance.MinusScore(score);
        // 사용되었으므로, 자신을 파괴
        Destroy(gameObject);
    }
}