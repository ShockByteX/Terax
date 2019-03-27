using System.Windows.Forms;

namespace TeraxHook.GUI.Controls
{
    public partial class FieldInfoControl : UserControl
    {
        #region Constructors
        public FieldInfoControl(string fieldName, string fieldValue)
        {
            InitializeComponent();
            lblFieldName.Text = fieldName;
            lblFieldValue.Text = fieldValue;
        }
        #endregion
    }
}