namespace BluntKeys
{
    partial class EditMappingDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMappingDialog));
            this.label_toKey = new System.Windows.Forms.Label();
            this.label_fromKey = new System.Windows.Forms.Label();
            this.listBox_toKeys = new System.Windows.Forms.ListBox();
            this.listBox_fromKeys = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_setToKey = new System.Windows.Forms.Button();
            this.button_setFromKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_toKey
            // 
            this.label_toKey.AutoSize = true;
            this.label_toKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toKey.Location = new System.Drawing.Point(641, 539);
            this.label_toKey.Name = "label_toKey";
            this.label_toKey.Size = new System.Drawing.Size(75, 46);
            this.label_toKey.TabIndex = 19;
            this.label_toKey.Text = "     ";
            // 
            // label_fromKey
            // 
            this.label_fromKey.AutoSize = true;
            this.label_fromKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fromKey.Location = new System.Drawing.Point(174, 539);
            this.label_fromKey.Name = "label_fromKey";
            this.label_fromKey.Size = new System.Drawing.Size(75, 46);
            this.label_fromKey.TabIndex = 18;
            this.label_fromKey.Text = "     ";
            // 
            // listBox_toKeys
            // 
            this.listBox_toKeys.FormattingEnabled = true;
            this.listBox_toKeys.ItemHeight = 31;
            this.listBox_toKeys.Location = new System.Drawing.Point(516, 66);
            this.listBox_toKeys.Name = "listBox_toKeys";
            this.listBox_toKeys.Size = new System.Drawing.Size(431, 438);
            this.listBox_toKeys.TabIndex = 17;
            // 
            // listBox_fromKeys
            // 
            this.listBox_fromKeys.FormattingEnabled = true;
            this.listBox_fromKeys.ItemHeight = 31;
            this.listBox_fromKeys.Location = new System.Drawing.Point(35, 66);
            this.listBox_fromKeys.Name = "listBox_fromKeys";
            this.listBox_fromKeys.Size = new System.Drawing.Size(434, 438);
            this.listBox_fromKeys.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(827, 766);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 70);
            this.button4.TabIndex = 15;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(665, 766);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 70);
            this.button3.TabIndex = 14;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_setToKey
            // 
            this.button_setToKey.Location = new System.Drawing.Point(649, 622);
            this.button_setToKey.Name = "button_setToKey";
            this.button_setToKey.Size = new System.Drawing.Size(155, 70);
            this.button_setToKey.TabIndex = 13;
            this.button_setToKey.Text = "Type Key";
            this.button_setToKey.UseVisualStyleBackColor = true;
            // 
            // button_setFromKey
            // 
            this.button_setFromKey.Location = new System.Drawing.Point(182, 622);
            this.button_setFromKey.Name = "button_setFromKey";
            this.button_setFromKey.Size = new System.Drawing.Size(155, 70);
            this.button_setFromKey.TabIndex = 12;
            this.button_setFromKey.Text = "Type Key";
            this.button_setFromKey.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Map key to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Map key from:";
            // 
            // EditMappingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 848);
            this.Controls.Add(this.label_toKey);
            this.Controls.Add(this.label_fromKey);
            this.Controls.Add(this.listBox_toKeys);
            this.Controls.Add(this.listBox_fromKeys);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_setToKey);
            this.Controls.Add(this.button_setFromKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMappingDialog";
            this.Text = "EditMappingDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_toKey;
        private System.Windows.Forms.Label label_fromKey;
        private System.Windows.Forms.ListBox listBox_toKeys;
        private System.Windows.Forms.ListBox listBox_fromKeys;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_setToKey;
        private System.Windows.Forms.Button button_setFromKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}