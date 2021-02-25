using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Ammo;
    public Transform AmmoStart;
    public float Delay;

    private void Start()
    {

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(_Shoot());
        }
    }

    public void Shoot()
    {
        GameObject NewShot = Instantiate(Ammo, AmmoStart.position, AmmoStart.rotation);
    }

    IEnumerator _Shoot()
    {
        yield return new WaitForSeconds(Delay);
        Shoot();
    }
}
