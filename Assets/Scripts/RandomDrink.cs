using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI ���� �ʿ���
using UnityEngine.UI;

public class RandomDrink : MonoBehaviour
{
    private Image randomDrinkImage;

    // Drink array ����
    public Sprite[] drink;

    void Start()
    {
    // Component ���� �� Start() �Ǵ� Awake() �Լ����� �̸� �����ؾ� ��
    // �ٸ� ���� ������Ʈ�� �ִ� ������Ʈ ���� ��
    // public GameObject other; ���� ��
    // tr = other.GetComponent<Transform>();
    // �Ǵ� Button button = GameObject.FindGameObjectWithTag("���ӿ�����Ʈ�̸�").GetComponent<Button>();
        randomDrinkImage = GetComponent<Image>();

    }

    void Update()
    {
        // 8���� ����� �� �ϳ��� �������� ���;� ��.
    }

    void ShowRandomDrink()
    {
        // Random�� ����Ͽ� �������� sprite�� ��ü����.
        int random = Random.Range(0, 8);
        randomDrinkImage.sprite = drink[random];

    }
}
