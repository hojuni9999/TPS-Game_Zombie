using UnityEngine;

// ���� ������ ���ҽ�Ű�� ������
public class MCoin : MonoBehaviour, IItem
{
    public int score = 200; // ������ ����

    public void Use(GameObject target)
    {
        // ���� �Ŵ����� ������ ���� �߰�
        GameManager.instance.MinusScore(score);
        // ���Ǿ����Ƿ�, �ڽ��� �ı�
        Destroy(gameObject);
    }
}