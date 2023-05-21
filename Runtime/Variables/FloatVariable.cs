using UnityEngine;

namespace TungHT.Core.Variables {
    [CreateAssetMenu(fileName = "NewFloatVariable", menuName = "Variables/FloatVariable")]
    public class FloatVariable : ScriptableObject {
#if UNITY_EDITOR
        [Multiline] public string DeveloperDescription = "";
#endif
        public float value;

        public void SetValue(float newValue)
        {
            value = newValue;
        }

        public void SetValue(FloatVariable newValue)
        {
            value = newValue.value;
        }

        public void ApplyChange(float amount)
        {
            value += amount;
        }

        public void ApplyChange(FloatVariable amount)
        {
            value += amount.value;
        }
    }
}
