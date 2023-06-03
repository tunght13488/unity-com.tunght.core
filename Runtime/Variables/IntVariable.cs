using UnityEngine;

namespace TungHT.Core.Variables {
    [CreateAssetMenu(fileName = "NewIntVariable", menuName = "Variables/IntVariable")]
    public class IntVariable : ScriptableObject {
#if UNITY_EDITOR
        [Multiline] public string DeveloperDescription = "";
#endif
        public int value;

        public void SetValue(int newValue)
        {
            value = newValue;
        }

        public void SetValue(IntVariable newValue)
        {
            value = newValue.value;
        }

        public void ApplyChange(int amount)
        {
            value += amount;
        }

        public void ApplyChange(IntVariable amount)
        {
            value += amount.value;
        }
    }
}
