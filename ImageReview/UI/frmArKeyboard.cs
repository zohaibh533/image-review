using ImageReview.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageReview.UI
{
    public partial class frmArKeyboard : Form
    {
        public event EventHandler<string> CharacterSelected;

        public frmArKeyboard()
        {
            InitializeComponent();
        }

        private void frmArKeyboard_Load(object sender, EventArgs e)
        {
            CreateKeyboard();
        }

        private void CreateKeyboard()
        {
            string arabicChars = "٠٩٨٧٦٥٤٣٢١";
            arabicChars = arabicChars + "رذدخحجثتبا";
            arabicChars = arabicChars + "فغعظطضصشسز";
            arabicChars = arabicChars + "ىوهنملكق";
            arabicChars = arabicChars + "<";
            arabicChars = arabicChars.Replace(" ", "");

            int x = 10, y = 10;

            foreach (char c in arabicChars)
            {
                if (c == ' ') continue;
                this.Controls.Add(MakeButton(c.ToString(), x, y));
                x += 97;
                if (x > 900) { x = 10; y += 63; }  //53 Move to next row if out of space
            }
        }

        private Button MakeButton(string txt, int x, int y)
        {
            Button btn = new Button();
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Calibri", 24F);
            btn.Location = new Point(x, y);
            btn.Size = new Size(92, 58);//52, 48,   
            btn.Text = string.Format("{0} {1}", txt, Utilis.GetEnglishCharacter(txt));
            btn.UseVisualStyleBackColor = true;
            btn.Click += (s, e) => CharacterSelected?.Invoke(this, txt);
            btn.PreviewKeyDown += KeyboardForm_PreviewKeyDown;

            return btn;
        }

        private void KeyboardForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void frmArKeyboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
