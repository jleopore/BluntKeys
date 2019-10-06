using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluntKeys
{
    public partial class MainForm : Form
    {
        ScanCodeMap keymap = new ScanCodeMap();
        const string kbRegKey = @"System\CurrentControlSet\Control\Keyboard Layout";

        public MainForm()
        {
            InitializeComponent();
            LoadKeyMapFromRegistry(null, null);
            UpdateKeymapList();
        }

        void SaveKeyMapToRegistry(object sender, EventArgs e)
        {
            using (var regScanMapKey = Registry.LocalMachine.CreateSubKey(kbRegKey))
                regScanMapKey.SetValue("Scancode Map", keymap.Serialize());

            statusLabel1.Text = "Mappings saved to registry. Changes will take effect at the next Windows sign-in.";
        }

        void LoadKeyMapFromRegistry(object sender, EventArgs e)
        {
            using (var regScanMapKey = Registry.LocalMachine.OpenSubKey(kbRegKey))
                if (regScanMapKey?.GetValue("Scancode Map") is object scMapValue)
                    keymap.Parse((byte[])scMapValue);

            UpdateKeymapList();
        }

        void ClearRegistry(object sender, EventArgs e)
        {
            using (var regScanMapKey = Registry.LocalMachine.CreateSubKey(kbRegKey))
                regScanMapKey.DeleteValue("Scancode Map", false);

            statusLabel1.Text = "Mappings cleared from registry. Changes will take effect at the next Windows sign-in.";
        }

        void SaveKeyMapToFile(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog() { Filter = ".skl Files|*.skl" })
                if (sfd.ShowDialog() == DialogResult.OK)
                    File.WriteAllBytes(sfd.FileName, keymap.Serialize());
        }

        void LoadKeyMapFromFile(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog() { Filter = ".skl Files|*.skl" })
                if (ofd.ShowDialog() == DialogResult.OK)
                    keymap.Parse(File.ReadAllBytes(ofd.FileName));

            UpdateKeymapList();
        }

        void ClearKeyMap(object sender, EventArgs e)
        {
            keymap = new ScanCodeMap();
            UpdateKeymapList();
        }

        void AddKey(object sender, EventArgs e)
        {
            using (var emd = new EditMappingDialog())
            {
                if (emd.ShowDialog() != DialogResult.OK)
                    return;

                keymap.Entries.Add((emd.FromKey, emd.ToKey));
                UpdateKeymapList();
            }
        }

        void EditKey(object sender, EventArgs e)
        {
            var selection = listBox_mappings.SelectedItem as KeyCaptionPair;
            using (var emd = new EditMappingDialog(selection.From.Value, selection.To.Value))
            {
                if (emd.ShowDialog() != DialogResult.OK)
                    return;

                //Replace the listbox selection with the edited result
                var index = keymap.Entries.IndexOf((selection.From.Value, selection.To.Value));
                keymap.Entries.Remove((selection.From.Value, selection.To.Value));
                keymap.Entries.Insert(index, (emd.FromKey, emd.ToKey));

                UpdateKeymapList();
            }
        }

        void DeleteKey(object sender, EventArgs e)
        {
            var selection = listBox_mappings.SelectedItem as KeyCaptionPair;
            keymap.Entries.Remove((selection.From.Value, selection.To.Value));

            UpdateKeymapList();
        }

        void SelectionChanged(object sender, EventArgs e)
        {
            button_edit.Enabled = button_remove.Enabled = listBox_mappings.SelectedIndex != -1;
        }

        void UpdateKeymapList()
        {
            listBox_mappings.Items.Clear();
            SelectionChanged(null, null);
            listBox_mappings.Items.AddRange(keymap.Entries
                .Select(a => new KeyCaptionPair(a.FromKey, a.ToKey))
                .ToArray());
        }
    }
}
