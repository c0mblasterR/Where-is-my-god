using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "God", menuName = "ScriptableObjects/CreateGod", order = 1)]
public class GodCreator : ScriptableObject
{
    //-------------------------------------------------------------------------------------------------------------------------//

    public string godName; // Tanrının adını saklayan string tipindeki değişken.
    public float godManaCost2Send; // Tanrıyı göndermek amacıyla ödenmesi gereken mana miktarını saklayan float tipindeki değişken.
    public float godMoneyCost2Send; // Tanrıyı göndermek amacıyla ödenmesi gereken para miktarını saklayan float tipindeki değişken.
    public string godFavoriteBiome; // Tanrının en etkili olduğu biyomu saklayan string tipindeki değişken.
    
    //-------------------------------------------------------------------------------------------------------------------------//
}
