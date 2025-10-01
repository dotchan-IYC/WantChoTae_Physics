using System;
using UnityEngine;

public class OnButtonClick : MonoBehaviour
{
    public bool Check {  get; private set; } //체크한거 내보낸다
    [SerializeField]
    private GameObject o;
    [SerializeField]
    private GameObject x;

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == o)
        {
            CheckUp(true);
        }
        else if (collision == x)
        {
            CheckUp(false);
        }
    }

    private bool CheckUp(bool real)
    {
        Check = real;
        return Check;
    }
}
