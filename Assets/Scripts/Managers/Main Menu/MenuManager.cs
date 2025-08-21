using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Button mainMenuQuitButton; // Ana menüde bulunan oyunu kapatma butonu.
    [SerializeField] private Button mainMenuOpenGameSceneButton; // Ana menüde bulunan oyunu başlatma ("Main Game" adlı sahneye geçiş) butonu.

    //-------------------------------------------------------------------------------------------------------------------------//

    // Sahne yüklendiğinde bir kere çalışır.
    private void Awake()
    {

    }

    // Obje aktif edildiğine bir kere çalışır.
    private void Start()
    {
        mainMenuQuitButton.onClick.AddListener(() => Application.Quit()); // Start fonksiyonu çalıştığı zaman oyunu kapatma butonuna basıldığında oyunu kapatma fonksiyonunu tetikleyecek dinleyici ekleyen kod satırı.
        mainMenuOpenGameSceneButton.onClick.AddListener(() => openGameScene()); // Start fonksiyonu çalıştığı zaman oyunu başlatan ("Main Game" adlı sahneye geçiş yapan) fonksiyonu tetikleyecek dinleyici ekleyen kod satırı.
    }

    // Oyun çalışıyorken her karede bir kere çalışır.
    private void Update()
    {

    }

    //-------------------------------------------------------------------------------------------------------------------------//

    // Main Game adlı sahneye geçiş yapan fonksiyon.
    private void openGameScene()
    {
        SceneManager.LoadScene("Main Game"); // Main Game adlı sahneye geçiş yapan kod satırı.
    }
}
