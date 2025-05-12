using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Model
{
    [CreateAssetMenu]
    public class ItemsDatabaseSo : ScriptableObject
    {
        public List<ItemData> Items;
    }
}
