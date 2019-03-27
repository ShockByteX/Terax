using System;
using System.Reflection;
using System.Windows.Forms;
using Tera.Core.Game;

namespace TeraxHook.GUI.Controls
{
    public partial class ExAngle : UserControl, ExControl
    {
        #region Fields
        private Type _type;
        #endregion
        #region Properties
        public Type FieldType => _type;
        public object FieldValue => new Angle((short)udValue.Value);
        #endregion
        #region Constructors
        public ExAngle(System.Reflection.FieldInfo field)
        {
            InitializeComponent();
            _type = field.FieldType;
            lblFieldName.Text = field.Name;
        }
        #endregion
    }
}