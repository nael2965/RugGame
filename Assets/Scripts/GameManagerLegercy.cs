using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using Utility;
using Random = UnityEngine.Random;
/*
public class GameManagerLegercy : MonoBehaviour
{
    private int _tryCountBuffer;
    public class Instance
    {
        public static object OnTap { get; set; }
        public static string totalTaps { get; set; }
        public static int playTime { get; set; }
    }

    // 터치 입력을 감지하기 위한 변수
    private bool isTouching = false;

    private void Update()
    {
        // 터치 입력 감지
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // 터치가 시작되었을 때
            if (touch.phase == TouchPhase.Began)
            {
                isTouching = true;
            }
            // 터치가 끝났을 때
            else if (touch.phase == TouchPhase.Ended)
            {
                isTouching = false;
            }
        }

        // 터치 중이고 특정 조건을 만족할 때 아이템 선택
        if (isTouching && IsPickItem(4, 10))
        {
            ItemDatabase.ItemData pickedItem = pickItem();
            // 여기에 선택된 아이템으로 수행할 작업을 추가하세요
        }
    }

    private bool IsPickItem(int min, int max)
    {
        // 시도 횟수를 증가시킴
        _tryCountBuffer++;

    // 최소 시도 횟수보다 적으면 false 반환
        if (_tryCountBuffer < min) return false;

    // 현재 시도 횟수가 min과 max 사이의 랜덤 값보다 크면 아이템 뽑기 성공
    bool bIsPicked = _tryCountBuffer > Random.Range(min, max);

    // 아이템을 뽑았다면 시도 횟수 초기화
        if (bIsPicked) _tryCountBuffer = 0;

    // 아이템 뽑기 성공 여부 반환
        return bIsPicked;
    }
    
    private ItemDatabase.ItemData pickItem()
    {
        // 전체 가중치 합계를 계산
        int totalWeight = ItemDatabase.Items.Sum(item => item.weight);
        
        // 0부터 전체 가중치 합계 사이의 랜덤 값 생성
        int random = Random.Range(0, totalWeight);
        
        // 선택된 아이템을 찾기 위한 누적 가중치
        int accumulatedWeight = 0;
        
        // 각 아이템에 대해 반복
        for (int i = 0; i < ItemDatabase.Items.Length; i++)
        {
            // 현재 아이템의 가중치를 누적
            accumulatedWeight += ItemDatabase.Items[i].weight;
            
            // 누적 가중치가 랜덤 값을 초과하면 해당 아이템 선택
            if (accumulatedWeight > random)
            {
                return ItemDatabase.Items[i];
            }
        }
        
        // 예외 처리: 아이템이 선택되지 않았을 경우 마지막 아이템 반환
        return ItemDatabase.Items[ItemDatabase.Items.Length - 1];
    }
}*/