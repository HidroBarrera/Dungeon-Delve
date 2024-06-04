using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public virtual void AppClose()
    {
        Application.Quit();
    }
}
