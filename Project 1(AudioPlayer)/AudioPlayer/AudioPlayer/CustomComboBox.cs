﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace AudioPlayer 
    {
    [DefaultEvent("SelectedIndexChanged")]
    class CustomComboBox : UserControl
    {
    private Color backColor = Color.WhiteSmoke;
    private Color iconColor = Color.MediumSlateBlue;
    private Color listBackColor = Color.FromArgb(230, 228, 245);
    private Color listTextColor = Color.DimGray;
    private Color borderColor = Color.MediumSlateBlue;

    private ComboBox cmbList;
    private Label lblText;
    private Button btnIcon;

        public new Color BackColor
        { 
            get
            { return backColor; }
            set 
            { backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }
        public Color IconColor
        { 
            get
            { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();
            }
        }
        public Color ListBackColor {
            get {return listBackColor; }
            set { listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }
        public Color ListTextColor { 
            get { return listTextColor; }
            set { listTextColor = value;
                cmbList.ForeColor = listTextColor; }
        }
        public Color BorderColor 
        {
            get { return borderColor; }
            set { borderColor = value;
                base.BackColor = borderColor;
            }
        }
        public override Color ForeColor {
            get { return base.ForeColor; }
            set { base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        public override Font Font { get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }  
        }
        public string Texts
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set{
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        // -> Data
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items 
        { 
            get { return cmbList.Items; }
        }

        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }


        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
                
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        public event EventHandler SelectedIndexChanged;

        public CustomComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ConboBox_TextChanged);

            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(20, 20);
            btnIcon.Click += new EventHandler(Icon_Click);
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);

            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 7F);
            lblText.Click += new EventHandler(Surface_Click);

            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(0, 0);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(0);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }


        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ConboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)
                SelectedIndexChanged.Invoke(sender, e);
            lblText.Text = cmbList.Text;
        }
    }
}
