namespace BindingFlagsTester
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
            System.Windows.Forms.Button btnGo;
            this._tbResults = new System.Windows.Forms.TextBox();
            this._gbChecks = new System.Windows.Forms.GroupBox();
            this._cbMemberType = new System.Windows.Forms.ComboBox();
            this._rbDerived = new System.Windows.Forms.RadioButton();
            this._rbBase = new System.Windows.Forms.RadioButton();
            btnGo = new System.Windows.Forms.Button();
            this._gbChecks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.Dock = System.Windows.Forms.DockStyle.Bottom;
            btnGo.Location = new System.Drawing.Point(3, 636);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(158, 23);
            btnGo.TabIndex = 2;
            btnGo.Text = "Go Baby Go!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += new System.EventHandler(this.OnGoButtonClick);
            // 
            // _tbResults
            // 
            this._tbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbResults.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tbResults.Location = new System.Drawing.Point(170, 0);
            this._tbResults.Multiline = true;
            this._tbResults.Name = "_tbResults";
            this._tbResults.ReadOnly = true;
            this._tbResults.Size = new System.Drawing.Size(469, 662);
            this._tbResults.TabIndex = 0;
            this._tbResults.WordWrap = false;
            // 
            // _gbChecks
            // 
            this._gbChecks.Controls.Add(this._cbMemberType);
            this._gbChecks.Controls.Add(btnGo);
            this._gbChecks.Controls.Add(this._rbDerived);
            this._gbChecks.Controls.Add(this._rbBase);
            this._gbChecks.Dock = System.Windows.Forms.DockStyle.Left;
            this._gbChecks.Location = new System.Drawing.Point(0, 0);
            this._gbChecks.Name = "_gbChecks";
            this._gbChecks.Size = new System.Drawing.Size(164, 662);
            this._gbChecks.TabIndex = 1;
            this._gbChecks.TabStop = false;
            this._gbChecks.Text = "Options";
            // 
            // _cbMemberType
            // 
            this._cbMemberType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbMemberType.FormattingEnabled = true;
            this._cbMemberType.Items.AddRange(new object[] {
            "Properties",
            "Methods",
            "Fields"});
            this._cbMemberType.Location = new System.Drawing.Point(13, 67);
            this._cbMemberType.Name = "_cbMemberType";
            this._cbMemberType.Size = new System.Drawing.Size(145, 21);
            this._cbMemberType.TabIndex = 3;
            // 
            // _rbDerived
            // 
            this._rbDerived.AutoSize = true;
            this._rbDerived.Location = new System.Drawing.Point(13, 43);
            this._rbDerived.Name = "_rbDerived";
            this._rbDerived.Size = new System.Drawing.Size(90, 17);
            this._rbDerived.TabIndex = 1;
            this._rbDerived.Text = "Derived Class";
            this._rbDerived.UseVisualStyleBackColor = true;
            // 
            // _rbBase
            // 
            this._rbBase.AutoSize = true;
            this._rbBase.Checked = true;
            this._rbBase.Location = new System.Drawing.Point(13, 20);
            this._rbBase.Name = "_rbBase";
            this._rbBase.Size = new System.Drawing.Size(77, 17);
            this._rbBase.TabIndex = 0;
            this._rbBase.TabStop = true;
            this._rbBase.Text = "Base Class";
            this._rbBase.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 662);
            this.Controls.Add(this._gbChecks);
            this.Controls.Add(this._tbResults);
            this.MinimumSize = new System.Drawing.Size(655, 700);
            this.Name = "MainForm";
            this.Text = "Binding Flags Tester";
            this._gbChecks.ResumeLayout(false);
            this._gbChecks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbResults;
        private System.Windows.Forms.GroupBox _gbChecks;
        private System.Windows.Forms.RadioButton _rbDerived;
        private System.Windows.Forms.RadioButton _rbBase;
        private System.Windows.Forms.ComboBox _cbMemberType;
    }
}

