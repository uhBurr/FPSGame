using System.Collections;
using UnityEngine;

public class HandgunFire : MonoBehaviour
{

    [SerializeField] AudioSource gunFire;
    [SerializeField] GameObject handgun;
    [SerializeField] bool canFire = true;
    [SerializeField] AudioSource emptyGunSound;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (canFire == true)
            {
                if (GlobalAmmo.handgunAmmoCount == 0)
                {
                    canFire = false;
                    StartCoroutine(EmptyGun());
                }
                else
                {
                    canFire = false;
                    StartCoroutine(FiringGun());
                }
                
            }
        }
    }

    IEnumerator FiringGun()
    {
        gunFire.Play();
        GlobalAmmo.handgunAmmoCount -= 1;
        handgun.GetComponent<Animator>().Play("HandGunFire");
        yield return new WaitForSeconds(0.5f);
        handgun.GetComponent<Animator>().Play("New State");
        yield return new WaitForSeconds(0.1f);
        canFire = true;
    }
    IEnumerator EmptyGun()
    {
        emptyGunSound.Play();
        yield return new WaitForSeconds(0.6f);
        canFire = true; 

    }
}
