using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // 加上 SerializeField attr 可以在编辑器里面动态调整 property 的值
    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime 是每一帧执行的时间，乘以它可以让游戏速度在任何电脑上都保持一致
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
}
