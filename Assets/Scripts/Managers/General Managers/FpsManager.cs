using UnityEngine;
using TMPro;

public class FpsManager : MonoBehaviour
{

    //-------------------------------------------------------------------------------------------------------------------------//

    // SerializeField Değişkenler //

    [Header("FPS Settings")]
    [SerializeField] private int targetFPS = 60;   // Maksimum FPS değerini saklayan değişken. (0 = sınırsız)
    [SerializeField] private TMP_Text fpsText;     // UI Text nesnesini saklayan değişken.
    [SerializeField] private float updateInterval = 2f; // FPS ölçümünün yapılacağı süre aralığı (saniye).

    //-------------------------------------------------------------------------------------------------------------------------//

    // Private Değişkenler //

    private float timeLeft;           // FPS ölçümü için kalan süre.
    private int frames;               // Ölçüm aralığında işlenen kare sayısı.
    private float accum;              // Ölçüm aralığında toplanan deltaTime değerleri.
    private static FpsManager instance;

    //-------------------------------------------------------------------------------------------------------------------------//


    // Sahne yüklendiğinde bir kere çalışır.
    void Awake()
    {
        // Singleton + DontDestroyOnLoad sistemi kurularak aynı anda yalnızca bir adet fps manager sistemi bulunması sağlanır.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    // Obje aktif edildiğinde bir kere çalışır.
    void Start()
    {
        if (targetFPS > 0)
        {
            Application.targetFrameRate = targetFPS; // Oyundaki maksimum fps değerini değişkene bağlı olarak düzenleyen kod satırı.
            QualitySettings.vSyncCount = 0; // vSync kapalı olmalı ki FPS sınırlaması çalışsın.
        }

        timeLeft = updateInterval; // İlk FPS ölçüm süresini başlatır.
    }

    // Oyun çalışıyorken her karede bir kere çalışır.
    void Update()
    {
        // DeltaTime topla ve frame sayısını arttır.
        timeLeft -= Time.unscaledDeltaTime;
        accum += Time.timeScale / Time.unscaledDeltaTime;
        ++frames;

        // Ölçüm süresi bittiğinde FPS hesapla.
        if (timeLeft <= 0.0f)
        {
            float fps = accum / frames;

            if (fpsText != null)
                fpsText.text = $"FPS: {Mathf.RoundToInt(fps)}";

            // Yeni ölçüm için resetle
            timeLeft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }

    // Çağırıldığında maksimum fps değeri sınırlayıcı değişkenini günceller.
    public void SetTargetFPS(int newFPS)
    {
        targetFPS = newFPS;
        if (targetFPS > 0)
            Application.targetFrameRate = targetFPS;
        else
            Application.targetFrameRate = -1; // sınırsız
    }
}