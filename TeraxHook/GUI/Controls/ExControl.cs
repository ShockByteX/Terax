using System;

namespace TeraxHook.GUI.Controls
{
    public interface ExControl
    {
        object FieldValue { get; }
        Type FieldType { get; }
    }
}