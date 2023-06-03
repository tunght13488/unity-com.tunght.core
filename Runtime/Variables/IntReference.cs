using System;

namespace TungHT.Core.Variables {
    [Serializable]
    public class IntReference {
        public bool useConstant = true;
        public int constantValue;
        public IntVariable variable;

        public IntReference()
        {
        }

        public IntReference(int value)
        {
            useConstant = true;
            constantValue = value;
        }

        public int Value => useConstant ? constantValue : variable.value;

        public static implicit operator int(IntReference reference) => reference.Value;
    }
}
