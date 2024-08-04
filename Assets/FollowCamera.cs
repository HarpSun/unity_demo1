using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 访问游戏中其他对象
    [SerializeField] GameObject thingsToFollow;

    void LateUpdate()
    {
        // 相机的位置和要跟随目标的位置一样，但是 z 坐标要向屏幕外方向移动一些
        transform.position = thingsToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
