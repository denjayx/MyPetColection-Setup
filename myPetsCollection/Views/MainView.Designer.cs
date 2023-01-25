
namespace myPetsCollection.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPets = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 565);
            this.panel1.TabIndex = 0;
            // 
            // btnPets
            // 
            this.btnPets.AllowAnimations = true;
            this.btnPets.AllowMouseEffects = true;
            this.btnPets.AllowToggling = false;
            this.btnPets.AnimationSpeed = 200;
            this.btnPets.AutoGenerateColors = false;
            this.btnPets.AutoRoundBorders = false;
            this.btnPets.AutoSizeLeftIcon = true;
            this.btnPets.AutoSizeRightIcon = true;
            this.btnPets.BackColor = System.Drawing.Color.Transparent;
            this.btnPets.BackColor1 = System.Drawing.Color.Fuchsia;
            this.btnPets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPets.BackgroundImage")));
            this.btnPets.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPets.ButtonText = "Show Pets";
            this.btnPets.ButtonTextMarginLeft = 0;
            this.btnPets.ColorContrastOnClick = 45;
            this.btnPets.ColorContrastOnHover = 45;
            this.btnPets.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPets.CustomizableEdges = borderEdges1;
            this.btnPets.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPets.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPets.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPets.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPets.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPets.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPets.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPets.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPets.IconMarginLeft = 11;
            this.btnPets.IconPadding = 10;
            this.btnPets.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPets.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPets.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPets.IconSize = 25;
            this.btnPets.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPets.IdleBorderRadius = 12;
            this.btnPets.IdleBorderThickness = 1;
            this.btnPets.IdleFillColor = System.Drawing.Color.Fuchsia;
            this.btnPets.IdleIconLeftImage = null;
            this.btnPets.IdleIconRightImage = null;
            this.btnPets.IndicateFocus = false;
            this.btnPets.Location = new System.Drawing.Point(22, 23);
            this.btnPets.Name = "btnPets";
            this.btnPets.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPets.OnDisabledState.BorderRadius = 12;
            this.btnPets.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPets.OnDisabledState.BorderThickness = 1;
            this.btnPets.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPets.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPets.OnDisabledState.IconLeftImage = null;
            this.btnPets.OnDisabledState.IconRightImage = null;
            this.btnPets.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPets.onHoverState.BorderRadius = 12;
            this.btnPets.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPets.onHoverState.BorderThickness = 1;
            this.btnPets.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPets.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPets.onHoverState.IconLeftImage = null;
            this.btnPets.onHoverState.IconRightImage = null;
            this.btnPets.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPets.OnIdleState.BorderRadius = 12;
            this.btnPets.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPets.OnIdleState.BorderThickness = 1;
            this.btnPets.OnIdleState.FillColor = System.Drawing.Color.Fuchsia;
            this.btnPets.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPets.OnIdleState.IconLeftImage = null;
            this.btnPets.OnIdleState.IconRightImage = null;
            this.btnPets.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPets.OnPressedState.BorderRadius = 12;
            this.btnPets.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPets.OnPressedState.BorderThickness = 1;
            this.btnPets.OnPressedState.FillColor = System.Drawing.Color.Purple;
            this.btnPets.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPets.OnPressedState.IconLeftImage = null;
            this.btnPets.OnPressedState.IconRightImage = null;
            this.btnPets.Size = new System.Drawing.Size(149, 48);
            this.btnPets.TabIndex = 14;
            this.btnPets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPets.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPets.TextMarginLeft = 0;
            this.btnPets.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPets.UseDefaultRadiusAndThickness = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 565);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainView";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPets;
    }
}