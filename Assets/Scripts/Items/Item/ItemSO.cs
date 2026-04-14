using UnityEngine;

namespace DungeonCrawler.Items.Item
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO")]
    public class ItemSO : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
    }
}
