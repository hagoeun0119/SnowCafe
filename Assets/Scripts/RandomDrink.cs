using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI ���� �ʿ���
using UnityEngine.UI;

public class RandomDrink : MonoBehaviour
{
    // Drink array ����
    public Sprite[] drink;

    // ���Ḧ �� ��������� Ȯ�� ����
    public bool checkDrink;    

    public GameObject other;
    public GameObject materials;

    void Start()
    {

    }

    void Update()
    {
        IsRightDrink();
    }

    void IsRightDrink()
    {
        checkDrink = other.GetComponent<MakeDrink>().needNewDrink;
        if (checkDrink == true)
        {
            other.GetComponent<MakeDrink>().needNewDrink = false;
            // Random�� ����Ͽ� �������� sprite�� ��ü����.
            int random = Random.Range(0, 8);
            gameObject.GetComponent<SpriteRenderer>().sprite = drink[random];
        }
    }

}
