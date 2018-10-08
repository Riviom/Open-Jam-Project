using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class Item : ScriptableObject
{

    public Sprite ItemSprite;
    public string AchievementText;
    public bool unlockedState;

}
