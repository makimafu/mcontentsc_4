using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HukidasiCreator : MonoBehaviour
{
    public GameObject hukidasi;
    public List<float> x_positions = new List<float> { -4f,4f };  // x���W�̃��X�g
    public List<float> y_positions = new List<float> { -2f, 0f, 2f };  // y���W�̃��X�g

    private float timer = 0f;   // �^�C�}�[�ϐ�
    private float spawnInterval = 1f;  // 1�b���Ƃ̃C���^�[�o��

    // Update is called once per frame
    void Update()
    {
        // ���t���[���A�o�ߎ��Ԃ𑝉�������
        timer += Time.deltaTime;

        // 1�b���Ƃ�hukidasi�I�u�W�F�N�g�𐶐�
        if (timer >= spawnInterval)
        {
            timer = 0f; // �^�C�}�[�����Z�b�g

            // �����_����x��y�̍��W��I��
            float randomX = x_positions[Random.Range(0, x_positions.Count)];
            float randomY = y_positions[Random.Range(0, y_positions.Count)];

            // �I�肳�ꂽ���W��hukidasi�I�u�W�F�N�g�𐶐�
            Vector2 spawnPosition = new Vector3(randomX, randomY, -3);
            Instantiate(hukidasi, spawnPosition, Quaternion.identity);
        }
    }
}
