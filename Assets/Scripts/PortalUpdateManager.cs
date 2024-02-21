using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalUpdateManager : MonoBehaviour
{
    public List<GameObject> Weapons = new List<GameObject>();
    private int activeIndex;
    private void OnEnable()
    {
        EventsManager.onAxePortal += AxeEnabled;
        EventsManager.onKnifePortal += KnifeEnabled;
        EventsManager.onGunPortal += GunEnabled;
    }
    private void OnDisable()
    {
        EventsManager.onAxePortal -= AxeEnabled;
        EventsManager.onKnifePortal -= KnifeEnabled;
        EventsManager.onGunPortal -= GunEnabled;
    }
    private void Start()
    {
        for (int i = 0; i < Weapons.Count; i++)
        {
            Weapons[i].gameObject.SetActive(false);
        }
    }
    void ToggleObject(int index)
    {
        //Deavtivate All game obj
        for (int i = 0; i < Weapons.Count; i++)
        {
            //toggle the activation state based on the provided index
            Weapons[i].gameObject.SetActive(i == index ? !Weapons[i].activeSelf : false);
        }
        activeIndex = index;
    }
    private void GunEnabled()
    {
        ToggleObject(2);
    }

    private void KnifeEnabled()
    {
        ToggleObject(1);
    }

    private void AxeEnabled()
    {
        ToggleObject(0);
    }
}
