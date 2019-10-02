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
    public partial class KeyInputDialog : Form, IMessageFilter
    {
        public ushort InputKey;

        public KeyInputDialog()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
        }

        public bool PreFilterMessage(ref Message msg)
        {
            if (msg.Msg == 0x100 || msg.Msg == 0x104) //WM_KEYDOWN or WM_SYSKEYDOWN
            {
                byte scancodebyte = (byte)((int)msg.LParam >> 16); //bits 16-23 of LParam are the scancode
                bool extendedKey = ((int)msg.LParam & (1 << 24)) != 0; //bit 24 is set if the scancode is an extended key

                //The registry represents normal and extended keys with a high byte of 00 and E0, respectively.
                InputKey = (ushort)(scancodebyte + (extendedKey ? 0xE000 : 0x0000));

                label_keypress.Text = InputKey.AsHexString();

                return true;    //Mark it as handled. (Windows responds first to some system keys)
            }

            return false;   //Don't intercept the message if it's not a keypress.
        }

        protected override void Dispose(bool disposing)
        {
            Application.RemoveMessageFilter(this);
            if (disposing) components?.Dispose();
            base.Dispose(disposing);
        }
    }
}
