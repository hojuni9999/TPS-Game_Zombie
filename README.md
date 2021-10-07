# TPS-Game_Zombie

### Develop a game project using Unity, A game to kill zombies with gun 

>*플레이어 상태, 공격, 움직임, 입력 Scipt* 구현 <br>
>*좀비 상태, 공격 구현*

#### 좀비가 플레이어를 추적하는 핵심 함수

~~~c#

private IEnumerator UpdatePath() {
        // 살아있는 동안 무한 루프
        while (!dead)
        {
            if (hasTarget)
            {
                //추적 대상 존재 :  경로를 갱신하고 AI 이동을 계속 진행
                pathFinder.isStopped = false;
                pathFinder.SetDestination(targetEntity.transform.position);
            }
            else
            {
                // 추적 대상 없음: AI 이동 중지
                pathFinder.isStopped = true;
                // 20유닛의 반지름을 가진 가상의 구를 그렸을 때 구와 겹치는 모든 콜라이더를 가져옴
                //단, whatIsTarget 레이어를 가진 콜라이더만 가져오도록 필터링
                Collider[] colliders = Physics.OverlapSphere(transform.position, 20f, whatIsTarget);
                //모든 콜라이더를 순회하면서 살아있는 LivingEntity 찾기
                for(int i = 0; i < colliders.Length; i++)
                {
                    //콜라이더로부터 LivingEntity 컴포넌트 가져오기
                    LivingEntity livingEntity = colliders[i].GetComponent<LivingEntity>();

                    //LivingEntity 컴포넌트가 존재하며, 해상 LivingEntity가 살아 있다면
                    if(livingEntity != null && !livingEntity.dead)
                    {
                        //추적 대상을 해당 LivingEntity로 설정
                        targetEntity = livingEntity;
                        break; // for문 즉시 정지
                    }
                }
            }
            // 0.25초 주기로 처리 반복
            yield return new WaitForSeconds(0.25f);
        }
    }
  
  ~~~
  
  #### 게임 실행화면
  
  ![1](https://user-images.githubusercontent.com/83167302/136426928-a71ae11d-5e7f-4842-bb68-04121a936b15.PNG)
  
  ![2](https://user-images.githubusercontent.com/83167302/136426957-3b0d2ba6-3419-4ded-ad87-0c5ad01641b9.PNG)
  
  > ### UI <br>
   플레이어 체력바를 하단에 동그라미로 배치 <br>
   피 튀기는 효과, 총알 자국등 Effect

#### 추후 개선 사항

좀비를 프로퍼티(객체화)화 하고 랜덤으로 생성하게 만들기, UI 수정 
스테이지 추가, 좀비 능력치 변화
