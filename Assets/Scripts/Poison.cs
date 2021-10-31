using UnityEngine;

// �þ߸� �����ϴ� ������
public class Poison : MonoBehaviour, IItem
{
    public float poison = 50;

    public void Use(GameObject target)
    {
        // ���޹��� ���� ������Ʈ�κ��� LivingEntity ������Ʈ �������� �õ�
        LivingEntity life = target.GetComponent<LivingEntity>();
        PlayerMovement move = target.GetComponent<PlayerMovement>();

        // LivingEntity������Ʈ�� �ִٸ�
        if (life != null)
        {
            move.p.SetActive(true); // �þ� ���� ������ Ȱ��ȭ
            life.Slowdamage(poison);
            
        }

        // ���Ǿ����Ƿ�, �ڽ��� �ı�
        Destroy(gameObject);
    }
}