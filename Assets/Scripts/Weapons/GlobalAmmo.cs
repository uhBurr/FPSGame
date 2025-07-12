using UnityEngine;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmoCount = 10;
    [SerializeField] GameObject AmmoDisplay;

    void Update()
    {
        AmmoDisplay.GetComponent<TMPro.TMP_Text>().text = "" + handgunAmmoCount;
    }
}

