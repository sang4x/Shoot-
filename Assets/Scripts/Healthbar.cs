using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Healthbar : MonoBehaviour
{
    public Image health;
    public TextMeshProUGUI TextMeshProUGUI;

    public void Updatebar(int currenvalue, int maxvalue)
    {
        health.fillAmount = ((float)currenvalue / (float)maxvalue);
        TextMeshProUGUI.text = currenvalue.ToString() + "/" + maxvalue.ToString();
    }
}
