using System;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;

namespace TeraxHook.GUI.Controls
{
    public partial class ExVector3 : UserControl, ExControl
    {
        #region Fields
        private Type _type;
        #endregion
        #region Properties
        public Type FieldType => _type;
        public object FieldValue => new Vector3((float)udX.Value, (float)udY.Value, (float)udZ.Value);
        #endregion
        #region Constructors
        public ExVector3(FieldInfo field)
        {
            InitializeComponent();
            _type = field.FieldType;
            lblFieldName.Text = field.Name;
        }
        #endregion
    }
}