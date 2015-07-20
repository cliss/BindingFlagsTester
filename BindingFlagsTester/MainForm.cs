using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BindingFlagsTester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _cbMemberType.SelectedIndex = 0;

            Point location = _cbMemberType.Location;
            int delta = _rbDerived.Location.Y - _rbBase.Location.Y;
            location.Y += _rbDerived.Height + delta;

            foreach (string value in Enum.GetNames(typeof(BindingFlags)))
            {
                CheckBox cb = new CheckBox
                {
                    Text = value,
                    Tag = Enum.Parse(typeof(BindingFlags), value),
                    Location = location,
                    Checked = value == "Instance" || value == "Public",
                    AutoSize = true
                };
                _gbChecks.Controls.Add(cb);
                location.Y += delta;
            }
        }

        private void OnGoButtonClick(object sender, EventArgs e)
        {
            int value = 0;

            foreach (Control c in _gbChecks.Controls)
            {
                CheckBox cb = c as CheckBox;
                if (cb != null && cb.Checked)
                {
                    value += Convert.ToInt32(cb.Tag);
                }
            }

            BindingFlags flags = (BindingFlags)value;

            Base b = _rbBase.Checked ? new Base() : new Derived();
            StringBuilder sb = new StringBuilder();

            if (_cbMemberType.SelectedItem.ToString() == "Properties")
            {
                foreach (PropertyInfo pi in b.GetType().GetProperties(flags))
                {
                    sb.AppendFormat("{0} {1}{2}",
                        pi.PropertyType.Name,
                        pi.Name,
                        Environment.NewLine);
                }
            }
            else if (_cbMemberType.SelectedItem.ToString() == "Fields")
            {
                foreach (FieldInfo fi in b.GetType().GetFields(flags))
                {
                    sb.AppendFormat("{0} {1}{2}",
                        fi.FieldType.Name,
                        fi.Name,
                        Environment.NewLine);
                }
            }
            else if (_cbMemberType.SelectedItem.ToString() == "Methods")
            {
                foreach (MethodInfo mi in b.GetType().GetMethods(flags))
                {
                    sb.AppendFormat("{0} {1}{2}",
                        mi.ReturnType.Name,
                        mi.Name,
                        Environment.NewLine);
                }
            }

            _tbResults.Text = sb.ToString();

        }
    }
}
