using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HukidasiCreator : MonoBehaviour
{
    public GameObject hukidasi;
    public List<float> x_positions = new List<float> { -4f,4f };  // x座標のリスト
    public List<float> y_positions = new List<float> { -2f, 0f, 2f };  // y座標のリスト

    private float timer = 0f;   // タイマー変数
    private float spawnInterval = 1f;  // 1秒ごとのインターバル

    // Update is called once per frame
    void Update()
    {
        // 毎フレーム、経過時間を増加させる
        timer += Time.deltaTime;

        // 1秒ごとにhukidasiオブジェクトを生成
        if (timer >= spawnInterval)
        {
            timer = 0f; // タイマーをリセット

            // ランダムにxとyの座標を選択
            float randomX = x_positions[Random.Range(0, x_positions.Count)];
            float randomY = y_positions[Random.Range(0, y_positions.Count)];

            // 選定された座標にhukidasiオブジェクトを生成
            Vector2 spawnPosition = new Vector3(randomX, randomY, -3);
            Instantiate(hukidasi, spawnPosition, Quaternion.identity);
        }
    }
}
