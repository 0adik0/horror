using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Width : MonoBehaviour
{

    public float maxLife = 100;
    public float curLife;
    float Drain = 1f;
    public Image iconUI;

    void Start()
    {
        curLife = maxLife;
    }
    void Update()
    {
        if (curLife > 0)
        {
            curLife -= Drain * Time.deltaTime;
        }

        if (curLife <= 0)
        {
            curLife = 0;
        }

        iconUI.transform.localScale = new Vector3(
    curLife / maxLife,
    iconUI.transform.localScale.y,
    iconUI.transform.localScale.z
    );
        if (curLife <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void AddLife()
    {
        curLife = maxLife;
    }
}