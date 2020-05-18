namespace SymbolGUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.SoT = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoT
            // 
            this.SoT.Tick += new System.EventHandler(this.SoT_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Move Back To Bottom Right",
            "Close Software",
            "≥ - \"Greater than or equal to\"",
            "≤ - \"Less than or equal to\"",
            "≠ - \"Not equals\"",
            "± - \"Plus-minus sign\"",
            "∧ - \"And\"",
            "∨ - \"Or\"",
            "¬ - \"Not\"",
            "≡ - \"Exactly Equal To\"",
            "⇒ - \"Implies\"",
            "⇔ - \"If and only if\"",
            "↓ - \"NOR\"",
            "↑ - \"NAND\"",
            "∃ - \"Existential Quantifier\"",
            "∀ - \"Universal Quantifier\"",
            "Ø - \"Empty Set\"",
            "∈ - \"Set Membership\"",
            "∉ - \"Set Membership Negation\"",
            "⊆ - \"Subset\"",
            "⊂ - \"Proper Subset\"",
            "∪ - \"Union\"",
            "∩ - \"Intersection\"",
            "⨄ - \"Disjoint Union\"",
            "↔ - \"Binary Relation\"",
            "→ - \"Function\"",
            "◦ - \"Relation\"",
            "• - \"Matrix\"",
            "⌊ - \"Floor/Round Open\"",
            "⌋ - \"Floor Close\"",
            "⌈ - \"Ceiling Open\"",
            "⌉ - \"Ceiling/Round Close\"",
            "α – \"Alpha Lower\"",
            "β – \"Beta Lower\"",
            "Δ - \"Delta Upper\"",
            "δ – \"Delta Lower\"",
            "θ – \"Theta Lower\"",
            "λ – \"Lambda Lower\"",
            "μ – \"Mu Lower\"",
            "π - \"Pi Lower\"",
            "Σ – \"Sigma Upper\"",
            "σ – \"Sigma Lower\"",
            "Ω - \"Omega Upper\"",
            "ω – \"Omega Lower\"",
            "∞ - \"Infinity\"",
            "- - \"Combining Overline / Bar\""});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(338, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Copy to Clipboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SymbolGUI 3.5";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SoT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

