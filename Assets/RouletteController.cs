using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;  // 旋轉速度   

    void Start()
    {
        // 影格速率設為60 FPS
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        // 按下滑鼠就設定旋轉速度
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 讓輪盤依照設定的速度旋轉
        transform.Rotate(0, 0, this.rotSpeed);

        // 讓輪盤減速（新增）
        this.rotSpeed *= 0.96f;
    }
}
