using UnityEngine;

namespace Assets.Scripts.Model
{
    public class DataItem
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public GameObject Prefab { get; private set; }
        // [field: SerializeField] public ObjectsType ObjectType { get; private set; }
    }
}