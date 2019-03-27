using System;
using System.Reflection;
using System.Windows.Forms;

namespace TeraxHook.GUI.Controls
{
    public partial class ExTextBox : UserControl, ExControl
    {
        #region Fields
        private Type _type;
        #endregion
        #region Properties
        public Type FieldType => _type;
        public object FieldValue => tbValue.Text;
        #endregion
        #region Constructors
        public ExTextBox(FieldInfo field)
        {
            InitializeComponent();
            _type = field.FieldType;
            lblFieldName.Text = field.Name;
            tbValue.Text = null;
        }
        #endregion
    }
}