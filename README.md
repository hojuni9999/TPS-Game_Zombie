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
   

### 게임설명 ppt

>1
![슬라이드1](https://user-images.githubusercontent.com/83167302/139575010-0fd24090-5869-4c04-ab5e-1bf311e82dac.PNG)
2
![슬라이드2](https://user-images.githubusercontent.com/83167302/139575013-ec8f6eda-1c45-45a1-8ad4-8ddfe8bc8614.PNG)
3
![슬라이드3](https://user-images.githubusercontent.com/83167302/139575014-9f7e4ce5-2576-4f8b-b9b2-99d42a37f6cc.PNG)
4
![슬라이드4](https://user-images.githubusercontent.com/83167302/139575016-99f9cca6-e9cf-41ad-8a92-eba625913e60.PNG)
5
![슬라이드5](https://user-images.githubusercontent.com/83167302/139575017-98fe61d6-fd96-4d51-916b-7e38ffb57c68.PNG)
6
![슬라이드6](https://user-images.githubusercontent.com/83167302/139575018-26a03551-da79-4136-b885-7cc39fa1f150.PNG)
7
![슬라이드7](https://user-images.githubusercontent.com/83167302/139575020-b3f986ae-587c-4a04-b4ff-2129123bf229.PNG)
8
![슬라이드8](https://user-images.githubusercontent.com/83167302/139575023-a0a8d93e-3d1c-467a-88b9-20844e730971.PNG)
9
![슬라이드9](https://user-images.githubusercontent.com/83167302/139575024-0008ca0d-91b7-4fac-b31e-18d0d01d0708.PNG)
10
![슬라이드10](https://user-images.githubusercontent.com/83167302/139575027-90e70aec-9847-4967-af0b-4fed3244e665.PNG)
11
![슬라이드11](https://user-images.githubusercontent.com/83167302/139575028-5f4ba648-c36c-443f-9732-97c80d105b81.PNG)
12
![슬라이드12](https://user-images.githubusercontent.com/83167302/139575030-813b571f-874b-460e-b676-eae12cf08c0a.PNG)
13
![슬라이드13](https://user-images.githubusercontent.com/83167302/139575031-1efbf34d-c692-4036-9abf-ca3b90a6a3bb.PNG)
14
![슬라이드14](https://user-images.githubusercontent.com/83167302/139575032-115d4b0a-0993-4f26-9152-b233ae07a545.PNG)

