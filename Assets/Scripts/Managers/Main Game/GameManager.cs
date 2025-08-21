using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //-------------------------------------------------------------------------------------------------------------------------//

    [Header("Society Properties")]

    // Wisdowm Properties
    private float societyCurrentWisdom; // Toplumun sahip olduğu bilgelik değerini saklayan float tipindeki değişken.
    private float societyMaxWisdom; // Toplumun sahip olabileceği maksimum bilgelik değerini saklayan float tipindeki değişken.

    // Piety Properties
    private float societyCurrentPiety; // Toplumun sahip olduğu dindarlık değerini saklayan float tipindeki değişken.
    private float societyMaxPiety; // Toplumun sahip olabileceği maksimum dindarlık değerini saklayan float tipindeki değişken.

    // Happiness Properties
    private float societyCurrentHappiness; // Toplumun sahip olduğu mutluluk değerini saklayan float tipindeki değişken.
    private float societyMaxHappiness; // Toplumun sahip olabileceği maksimum mutluluk değerini saklayan float tipindeki değişken.

    // Wealth Properties
    private float societyCurrentWealth; // Toplumun sahip olduğu zenginlik değerini saklayan float tipindeki değişken.
    private float societyMaxWealth; // Toplumun sahip olabileceği maksimum zenginlik değerini saklayan float tipindeki değişken.

    //-------------------------------------------------------------------------------------------------------------------------//

    [Header("Executive Actor Properties")]

    // Mana Properties
    private float executiveActorCurrentMana; // Yönetici oyuncunun sahip olduğu mana değerini saklayan float tipindeki değişken.
    private float executiveActorMaxMana; // Yönetici oyuncunun sahip olabileceği maksimum mana değerini saklayan float tipindeki değişken.

    // Money Properties
    private float executiveActorCurrentMoney; // Yönetici oyuncunun sahip olduğu para değerini saklayan float tipindeki değişken.
    private float executiveActorMaxMoney; // Yönetici oyuncunun sahip olabileceği maksimum para değerini saklayan float tipindeki değişken.

    //-------------------------------------------------------------------------------------------------------------------------//

    void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }
    
}
