using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluntKeys
{
    public partial class EditMappingDialog : Form
    {
        public ushort FromKey, ToKey;

        public EditMappingDialog() => InitializeAndPopulate();
        public EditMappingDialog(ushort fromKey, ushort toKey)
        {
            InitializeAndPopulate();

            FromKey = fromKey;
            ToKey = toKey;
            updateLabels();
        }

        void InitializeAndPopulate()
        {
            InitializeComponent();

            var keyCapCollection = KeyCaption.StandardCaptions
                .Select(a => new KeyCaption(a.Key))
                .OrderBy(a => a.Value)
                .ToArray();

            listBox_fromKeys.Items.AddRange(keyCapCollection);
            listBox_toKeys.Items.AddRange(keyCapCollection);
        }

        private void TypeFromKey(object sender, EventArgs e)
        {
            using (var keyForm = new KeyInputDialog())
            {
                if (keyForm.ShowDialog() != DialogResult.OK)
                    return;

                FromKey = keyForm.InputKey;
                updateLabels();
            }            
        }

        private void TypeToKey(object sender, EventArgs e)
        {
            using (var keyForm = new KeyInputDialog())
            {
                if (keyForm.ShowDialog() != DialogResult.OK)
                    return;

                ToKey = keyForm.InputKey;
                updateLabels();
            }            
        }

        private void SelectFromKey(object sender, EventArgs e)
        {
            var kc = listBox_fromKeys.SelectedItem as KeyCaption;
            FromKey = kc.Value;
            updateLabels();
        }

        private void SelectToKey(object sender, EventArgs e)
        {
            var kc = listBox_toKeys.SelectedItem as KeyCaption;
            ToKey = kc.Value;
            updateLabels();
        }

        private void updateLabels()
        {
            label_fromKey.Text = FromKey.AsHexString();
            label_toKey.Text = ToKey.AsHexString();
        }
    }
}
