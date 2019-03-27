using System;
using System.Reflection;
using System.Windows.Forms;

namespace TeraxHook.GUI.Controls
{
    public partial class ExEnum : UserControl, ExControl
    {
        #region Fields
        private Type _type;
        private object _value;
        #endregion
        #region Properties
        public Type FieldType => _type;
        public object FieldValue => _value;
        #endregion
        #region Constructors
        public ExEnum(FieldInfo field)
        {
            InitializeComponent();
            _type = field.FieldType.GetEnumUnderlyingType();
            lblFieldName.Text = field.Name;
            string[] names = field.FieldType.GetEnumNames();
            Array values = field.FieldType.GetEnumValues();
            int length = names.Length;
            for (int i = 0; i < length; i++) cbxValue.Items.Add(new LObject(names[i], values.GetValue(i)));
            cbxValue.SelectedIndexChanged += cbxValue_SelectedIndexChanged;
            cbxValue.SelectedIndex = 0;
        }
        #endregion
        #region [PRIVATE]Methods
        private void cbxValue_SelectedIndexChanged(object sender, EventArgs e) => _value = ((LObject)cbxValue.SelectedItem).Value;
        #endregion
        #region [NESTED]Classes
        private class LObject
        {
            #region Fields
            public readonly string Name;
            public readonly object Value;
            #endregion
            #region Constructors
            public LObject(string name, object value) { Name = name; Value = value; }
            #endregion
            #region [PUBLIC]Overrides
            public override string ToString() => Name;
            #endregion
        }
        #endregion
    }
}