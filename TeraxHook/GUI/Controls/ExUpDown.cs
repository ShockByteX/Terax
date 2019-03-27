using System;
using System.Windows.Forms;
using System.Reflection;

namespace TeraxHook.GUI.Controls
{
    public partial class ExUpDown : UserControl, ExControl
    {
        #region Fields
        private Type _type;
        #endregion
        #region Properties
        public Type FieldType => _type;
        public object FieldValue
        {
            get
            {
                switch (Type.GetTypeCode(_type))
                {
                    case TypeCode.SByte: return (sbyte)udValue.Value;
                    case TypeCode.Byte: return (byte)udValue.Value;
                    case TypeCode.Int16: return (short)udValue.Value;
                    case TypeCode.UInt16: return (ushort)udValue.Value;
                    case TypeCode.Int32: return (int)udValue.Value;
                    case TypeCode.UInt32: return (uint)udValue.Value;
                    case TypeCode.Int64: return (long)udValue.Value;
                    case TypeCode.UInt64: return (ulong)udValue.Value;
                    case TypeCode.Single: return (float)udValue.Value;
                    case TypeCode.Double: return (double)udValue.Value;
                    default: throw new Exception("Type is not supported.");
                }
            }
        }
        #endregion
        #region Constructors
        public ExUpDown(FieldInfo field)
        {
            InitializeComponent();
            _type = field.FieldType;
            lblFieldName.Text = field.Name;
            udValue.Value = 0;
            switch (Type.GetTypeCode(_type))
            {
                case TypeCode.SByte: udValue.Minimum = sbyte.MinValue; udValue.Maximum = sbyte.MaxValue; break;
                case TypeCode.Byte: udValue.Minimum = byte.MinValue; udValue.Maximum = byte.MaxValue; break;
                case TypeCode.Int16: udValue.Minimum = short.MinValue; udValue.Maximum = short.MaxValue; break;
                case TypeCode.UInt16: udValue.Minimum = ushort.MinValue; udValue.Maximum = ushort.MaxValue; break;
                case TypeCode.Int32: udValue.Minimum = int.MinValue; udValue.Maximum = int.MaxValue; break;
                case TypeCode.UInt32: udValue.Minimum = uint.MinValue; udValue.Maximum = uint.MaxValue; break;
                case TypeCode.Int64: udValue.Minimum = long.MinValue; udValue.Maximum = long.MaxValue; break;
                case TypeCode.UInt64: udValue.Minimum = ulong.MinValue; udValue.Maximum = ulong.MaxValue; break;
                case TypeCode.Single: udValue.Minimum = -99999m; udValue.Maximum = +99999m; udValue.DecimalPlaces = 4; udValue.Increment = 0.1m; break;
                case TypeCode.Double: udValue.Minimum = -99999m; udValue.Maximum = +99999m; udValue.DecimalPlaces = 4; udValue.Increment = 0.1m; break;
                default: throw new Exception("Type is not supported.");
            }
        }
        #endregion
    }
}