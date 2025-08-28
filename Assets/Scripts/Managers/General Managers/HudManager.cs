using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//-----------------------------------------------------------------------------------------------------------------------//

// Önemli Not//
// - Hud Manager objesi için Don't Destroy on Load sistemi FpsManager adlı scriptte bulunduğu için,
// HudManager.cs scriptinde barındırılmayacaktır. FpsManager.cs dosyasından ilgili metot bulunabilir.

//-----------------------------------------------------------------------------------------------------------------------//


public class HudManager : MonoBehaviour
{


    //-------------------------------------------------------------------------------------------------------------------------//

    // SerializeField Değişkenler //
    [SerializeField] private GameObject hudCanvasGameObject; // HUD canvas nesnesini saklayan değişken.



    //-------------------------------------------------------------------------------------------------------------------------//
    // Sahne yüklendiğinde bir kere çalışır.
    private void Awake()
    {

    }

    // Obje aktif edildiğine bir kere çalışır.
    private void Start()
    {

    }

    // Oyun çalışıyorken her karede bir kere çalışır.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F3)) // F3 tuşuna basıldığında
        {
            ToggleHudCanvas(); // HUD canvas nesnesinin aktiflik durumunu değiştirir.
        }
    }

    // HUD canvas nesnesinin aktiflik durumunu değiştirir.
    public void ToggleHudCanvas()
    {
        if (hudCanvasGameObject != null) // HUD canvas nesnesi var mı?
        {
            hudCanvasGameObject.SetActive(!hudCanvasGameObject.activeSelf); // HUD canvas nesnesinin aktiflik durumunu değiştirir.
        }
    }
}
