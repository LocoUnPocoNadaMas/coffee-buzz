using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    [Serializable]
    public class ItemData
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public GameObject Prefab { get; private set; }
        // [field: SerializeField] public ObjectsType ObjectType { get; private set; }
    }
}