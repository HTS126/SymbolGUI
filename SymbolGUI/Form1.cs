using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Net.Mail;
using System.Net.Http;
using Microsoft.VisualBasic;

namespace SymbolGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
        }

        private void SoT_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
            //Rectangle workingArea = Screen.GetWorkingArea(this);
            //this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Move Back To Bottom Right")
            {
                Rectangle workingArea = Screen.GetWorkingArea(this);
                this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            }
            else if (comboBox1.Text == "Close Software")
            {
                Environment.Exit(0);
            }
            else if (comboBox1.Text == "≥ - \"Greater than or equal to\"")
            {
                Clipboard.SetText("≥");
            }
            else if (comboBox1.Text == "≤ - \"Less than or equal to\"")
            {
                Clipboard.SetText("≤");
            }
            else if (comboBox1.Text == "≠ - \"Not equals\"")
            {
                Clipboard.SetText("≠");
            }
            else if (comboBox1.Text == "± - \"Plus - minus sign\"")
            {
                Clipboard.SetText("±");
            }
            else if (comboBox1.Text == "∧ - \"And\"")
            {
                Clipboard.SetText("∧");
            }
            else if (comboBox1.Text == "∨ - \"Or\"")
            {
                Clipboard.SetText("∨");
            }
            else if (comboBox1.Text == "¬ - \"Not\"")
            {
                Clipboard.SetText("¬");
            }
            else if (comboBox1.Text == "≡ - \"Exactly Equal To\"")
            {
                Clipboard.SetText("≡");
            }
            else if (comboBox1.Text == "⇒ - \"Implies\"")
            {
                Clipboard.SetText("⇒");
            }
            else if (comboBox1.Text == "⇔ - \"If and only if\"")
            {
                Clipboard.SetText("⇔");
            }
            else if (comboBox1.Text == "↓ - \"NOR\"")
            {
                Clipboard.SetText("↓");
            }
            else if (comboBox1.Text == "↑ - \"NAND\"")
            {
                Clipboard.SetText("↑");
            }
            else if (comboBox1.Text == "∃ - \"Existential Quantifier\"")
            {
                Clipboard.SetText("∃");
            }
            else if (comboBox1.Text == "∀ - \"Universal Quantifier\"")
            {
                Clipboard.SetText("∀");
            }
            else if (comboBox1.Text == "Ø - \"Empty Set\"")
            {
                Clipboard.SetText("Ø");
            }
            else if (comboBox1.Text == "∈ - \"Set Membership\"")
            {
                Clipboard.SetText("∈");
            }
            else if (comboBox1.Text == "∉ - \"Set Membership Negation\"")
            {
                Clipboard.SetText("∉");
            }
            else if (comboBox1.Text == "π - \"Pi Lower\"")
            {
                Clipboard.SetText("π");
            }
            else if (comboBox1.Text == "⊆ - \"Subset\"")
            {
                Clipboard.SetText("⊆");
            }
            else if (comboBox1.Text == "⊂ - \"Proper Subset\"")
            {
                Clipboard.SetText("⊂");
            }
            else if (comboBox1.Text == "∪ - \"Union\"")
            {
                Clipboard.SetText("∪");
            }
            else if (comboBox1.Text == "∩ - \"Intersection\"")
            {
                Clipboard.SetText("∩");
            }
            else if (comboBox1.Text == "⨄ - \"Disjoint Union\"")
            {
                Clipboard.SetText("⨄");
            }
            else if (comboBox1.Text == "↔ - \"Binary Relation\"")
            {
                Clipboard.SetText("↔");
            }
            else if (comboBox1.Text == "→ - \"Function\"")
            {
                Clipboard.SetText("→");
            }
            else if (comboBox1.Text == "◦ - \"Relation\"")
            {
                Clipboard.SetText("◦");
            }
            else if (comboBox1.Text == "• - \"Matrix\"")
            {
                Clipboard.SetText("•");
            }
            else if (comboBox1.Text == "⌊ - \"Floor/Round Open\"")
            {
                Clipboard.SetText("⌊");
            }
            else if (comboBox1.Text == "⌋ - \"Floor Close\"")
            {
                Clipboard.SetText("⌋");
            }
            else if (comboBox1.Text == "⌈ - \"Ceiling Open\"")
            {
                Clipboard.SetText("⌈");
            }
            else if (comboBox1.Text == "⌉ - \"Ceiling/Round Close\"")
            {
                Clipboard.SetText("⌉");
            }
            else if (comboBox1.Text == "Ω - \"Omega Upper\"")
            {
                Clipboard.SetText("Ω");
            }
            else if (comboBox1.Text == "ω – \"Omega Lower\"")
            {
                Clipboard.SetText("ω");
            }
            else if (comboBox1.Text == "α – \"Alpha Lower\"")
            {
                Clipboard.SetText("α");
            }
            else if (comboBox1.Text == "β – \"Beta Lower\"")
            {
                Clipboard.SetText("β");
            }
            else if (comboBox1.Text == "δ – \"Delta Lower\"")
            {
                Clipboard.SetText("δ");
            }
            else if (comboBox1.Text == "θ – \"Theta Lower\"")
            {
                Clipboard.SetText("θ");
            }
            else if (comboBox1.Text == "λ – \"Lambda Lower\"")
            {
                Clipboard.SetText("λ");
            }
            else if (comboBox1.Text == "μ – \"Mu Lower\"")
            {
                Clipboard.SetText("μ");
            }
            else if (comboBox1.Text == "Σ – \"Sigma Upper\"")
            {
                Clipboard.SetText("Σ");
            }
            else if (comboBox1.Text == "σ – \"Sigma Lower\"")
            {
                Clipboard.SetText("σ");
            }
            else if (comboBox1.Text == "Δ - \"Delta Upper\"")
            {
                Clipboard.SetText("Δ");
            }
            else if (comboBox1.Text == "∞ - \"Infinity\"")
            {
                Clipboard.SetText("∞");
            }
            else if (comboBox1.Text == "- - \"Combining Overline / Bar\"")
            {
                Clipboard.SetText(" ̅ ");
            }
            else
            {
                Clipboard.SetText("Error");
            }
        }
    }
}