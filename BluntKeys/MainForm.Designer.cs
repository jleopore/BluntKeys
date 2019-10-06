namespace BluntKeys
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_keyset = new System.Windows.Forms.Label();
            this.listBox_mappings = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_loadFromRegistry = new System.Windows.Forms.Button();
            this.button_loadFromFile = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_removeAll = new System.Windows.Forms.Button();
            this.button_saveToRegistry = new System.Windows.Forms.Button();
            this.button_saveToFile = new System.Windows.Forms.Button();
            this.button_clearRegistry = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_keyset
            // 
            this.label_keyset.AutoSize = true;
            this.label_keyset.Location = new System.Drawing.Point(492, 9);
            this.label_keyset.Name = "label_keyset";
            this.label_keyset.Size = new System.Drawing.Size(195, 32);
            this.label_keyset.TabIndex = 0;
            this.label_keyset.Text = "Key Mappings";
            // 
            // listBox_mappings
            // 
            this.listBox_mappings.FormattingEnabled = true;
            this.listBox_mappings.ItemHeight = 31;
            this.listBox_mappings.Location = new System.Drawing.Point(12, 54);
            this.listBox_mappings.Name = "listBox_mappings";
            this.listBox_mappings.Size = new System.Drawing.Size(1131, 469);
            this.listBox_mappings.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 829);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1157, 48);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(58, 43);
            this.statusLabel1.Text = "     ";
            // 
            // button_loadFromRegistry
            // 
            this.button_loadFromRegistry.Location = new System.Drawing.Point(12, 533);
            this.button_loadFromRegistry.Name = "button_loadFromRegistry";
            this.button_loadFromRegistry.Size = new System.Drawing.Size(280, 60);
            this.button_loadFromRegistry.TabIndex = 3;
            this.button_loadFromRegistry.Text = "Load from Registry";
            this.button_loadFromRegistry.UseVisualStyleBackColor = true;
            this.button_loadFromRegistry.Click += new System.EventHandler(this.LoadKeyMapFromRegistry);
            // 
            // button_loadFromFile
            // 
            this.button_loadFromFile.Location = new System.Drawing.Point(12, 599);
            this.button_loadFromFile.Name = "button_loadFromFile";
            this.button_loadFromFile.Size = new System.Drawing.Size(280, 60);
            this.button_loadFromFile.TabIndex = 4;
            this.button_loadFromFile.Text = "Load from File...";
            this.button_loadFromFile.UseVisualStyleBackColor = true;
            this.button_loadFromFile.Click += new System.EventHandler(this.LoadKeyMapFromFile);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(430, 533);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(280, 60);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "Add...";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.AddKey);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(430, 599);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(280, 60);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "Edit Selected...";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.EditKey);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(430, 665);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(280, 60);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "Remove Selected";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.DeleteKey);
            // 
            // button_removeAll
            // 
            this.button_removeAll.Location = new System.Drawing.Point(430, 731);
            this.button_removeAll.Name = "button_removeAll";
            this.button_removeAll.Size = new System.Drawing.Size(280, 60);
            this.button_removeAll.TabIndex = 8;
            this.button_removeAll.Text = "Remove All";
            this.button_removeAll.UseVisualStyleBackColor = true;
            this.button_removeAll.Click += new System.EventHandler(this.ClearKeyMap);
            // 
            // button_saveToRegistry
            // 
            this.button_saveToRegistry.Location = new System.Drawing.Point(863, 533);
            this.button_saveToRegistry.Name = "button_saveToRegistry";
            this.button_saveToRegistry.Size = new System.Drawing.Size(280, 60);
            this.button_saveToRegistry.TabIndex = 9;
            this.button_saveToRegistry.Text = "Save to Registry";
            this.button_saveToRegistry.UseVisualStyleBackColor = true;
            this.button_saveToRegistry.Click += new System.EventHandler(this.SaveKeyMapToRegistry);
            // 
            // button_saveToFile
            // 
            this.button_saveToFile.Location = new System.Drawing.Point(863, 599);
            this.button_saveToFile.Name = "button_saveToFile";
            this.button_saveToFile.Size = new System.Drawing.Size(280, 60);
            this.button_saveToFile.TabIndex = 10;
            this.button_saveToFile.Text = "Save to File...";
            this.button_saveToFile.UseVisualStyleBackColor = true;
            this.button_saveToFile.Click += new System.EventHandler(this.SaveKeyMapToFile);
            // 
            // button_clearRegistry
            // 
            this.button_clearRegistry.Location = new System.Drawing.Point(863, 740);
            this.button_clearRegistry.Name = "button_clearRegistry";
            this.button_clearRegistry.Size = new System.Drawing.Size(280, 60);
            this.button_clearRegistry.TabIndex = 11;
            this.button_clearRegistry.Text = "Clear Registry";
            this.button_clearRegistry.UseVisualStyleBackColor = true;
            this.button_clearRegistry.Click += new System.EventHandler(this.ClearRegistry);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 877);
            this.Controls.Add(this.button_clearRegistry);
            this.Controls.Add(this.button_saveToFile);
            this.Controls.Add(this.button_saveToRegistry);
            this.Controls.Add(this.button_removeAll);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_loadFromFile);
            this.Controls.Add(this.button_loadFromRegistry);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox_mappings);
            this.Controls.Add(this.label_keyset);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BluntKeys";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_keyset;
        private System.Windows.Forms.ListBox listBox_mappings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.Button button_loadFromRegistry;
        private System.Windows.Forms.Button button_loadFromFile;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_removeAll;
        private System.Windows.Forms.Button button_saveToRegistry;
        private System.Windows.Forms.Button button_saveToFile;
        private System.Windows.Forms.Button button_clearRegistry;
    }
}

