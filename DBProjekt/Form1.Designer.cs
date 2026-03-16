namespace DBProjekt
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label ausweisnummerLabel;
            System.Windows.Forms.Label geburtsdatumLabel;
            System.Windows.Forms.Label nachnameLabel;
            System.Windows.Forms.Label pK_GastLabel;
            System.Windows.Forms.Label registrierungsdatumLabel;
            System.Windows.Forms.Label sperrstatusLabel;
            System.Windows.Forms.Label vIPLabel;
            System.Windows.Forms.Label vornameLabel;
            this.casino_gastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casino_gastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.casino_gastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.ausweisnummerTextBox = new System.Windows.Forms.TextBox();
            this.geburtsdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nachnameTextBox = new System.Windows.Forms.TextBox();
            this.pK_GastTextBox = new System.Windows.Forms.TextBox();
            this.registrierungsdatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sperrstatusCheckBox = new System.Windows.Forms.CheckBox();
            this.vIPCheckBox = new System.Windows.Forms.CheckBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            adresseLabel = new System.Windows.Forms.Label();
            ausweisnummerLabel = new System.Windows.Forms.Label();
            geburtsdatumLabel = new System.Windows.Forms.Label();
            nachnameLabel = new System.Windows.Forms.Label();
            pK_GastLabel = new System.Windows.Forms.Label();
            registrierungsdatumLabel = new System.Windows.Forms.Label();
            sperrstatusLabel = new System.Windows.Forms.Label();
            vIPLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casino_gastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casino_gastBindingNavigator)).BeginInit();
            this.casino_gastBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // casino_gastBindingSource
            // 
            this.casino_gastBindingSource.DataSource = typeof(DBProjekt.casino_gast);
            // 
            // casino_gastBindingNavigator
            // 
            this.casino_gastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.casino_gastBindingNavigator.BindingSource = this.casino_gastBindingSource;
            this.casino_gastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.casino_gastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.casino_gastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.casino_gastBindingNavigatorSaveItem});
            this.casino_gastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.casino_gastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.casino_gastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.casino_gastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.casino_gastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.casino_gastBindingNavigator.Name = "casino_gastBindingNavigator";
            this.casino_gastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.casino_gastBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.casino_gastBindingNavigator.TabIndex = 0;
            this.casino_gastBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // casino_gastBindingNavigatorSaveItem
            // 
            this.casino_gastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.casino_gastBindingNavigatorSaveItem.Enabled = false;
            this.casino_gastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("casino_gastBindingNavigatorSaveItem.Image")));
            this.casino_gastBindingNavigatorSaveItem.Name = "casino_gastBindingNavigatorSaveItem";
            this.casino_gastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.casino_gastBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Location = new System.Drawing.Point(50, 144);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(48, 13);
            adresseLabel.TabIndex = 1;
            adresseLabel.Text = "Adresse:";
            // 
            // adresseTextBox
            // 
            this.adresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_gastBindingSource, "Adresse", true));
            this.adresseTextBox.Location = new System.Drawing.Point(162, 141);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresseTextBox.TabIndex = 2;
            // 
            // ausweisnummerLabel
            // 
            ausweisnummerLabel.AutoSize = true;
            ausweisnummerLabel.Location = new System.Drawing.Point(50, 170);
            ausweisnummerLabel.Name = "ausweisnummerLabel";
            ausweisnummerLabel.Size = new System.Drawing.Size(86, 13);
            ausweisnummerLabel.TabIndex = 3;
            ausweisnummerLabel.Text = "Ausweisnummer:";
            // 
            // ausweisnummerTextBox
            // 
            this.ausweisnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_gastBindingSource, "Ausweisnummer", true));
            this.ausweisnummerTextBox.Location = new System.Drawing.Point(162, 167);
            this.ausweisnummerTextBox.Name = "ausweisnummerTextBox";
            this.ausweisnummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.ausweisnummerTextBox.TabIndex = 4;
            // 
            // geburtsdatumLabel
            // 
            geburtsdatumLabel.AutoSize = true;
            geburtsdatumLabel.Location = new System.Drawing.Point(50, 197);
            geburtsdatumLabel.Name = "geburtsdatumLabel";
            geburtsdatumLabel.Size = new System.Drawing.Size(76, 13);
            geburtsdatumLabel.TabIndex = 5;
            geburtsdatumLabel.Text = "Geburtsdatum:";
            // 
            // geburtsdatumDateTimePicker
            // 
            this.geburtsdatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casino_gastBindingSource, "Geburtsdatum", true));
            this.geburtsdatumDateTimePicker.Location = new System.Drawing.Point(162, 193);
            this.geburtsdatumDateTimePicker.Name = "geburtsdatumDateTimePicker";
            this.geburtsdatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.geburtsdatumDateTimePicker.TabIndex = 6;
            // 
            // nachnameLabel
            // 
            nachnameLabel.AutoSize = true;
            nachnameLabel.Location = new System.Drawing.Point(50, 222);
            nachnameLabel.Name = "nachnameLabel";
            nachnameLabel.Size = new System.Drawing.Size(62, 13);
            nachnameLabel.TabIndex = 7;
            nachnameLabel.Text = "Nachname:";
            // 
            // nachnameTextBox
            // 
            this.nachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_gastBindingSource, "Nachname", true));
            this.nachnameTextBox.Location = new System.Drawing.Point(162, 219);
            this.nachnameTextBox.Name = "nachnameTextBox";
            this.nachnameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nachnameTextBox.TabIndex = 8;
            // 
            // pK_GastLabel
            // 
            pK_GastLabel.AutoSize = true;
            pK_GastLabel.Location = new System.Drawing.Point(50, 248);
            pK_GastLabel.Name = "pK_GastLabel";
            pK_GastLabel.Size = new System.Drawing.Size(49, 13);
            pK_GastLabel.TabIndex = 9;
            pK_GastLabel.Text = "PK Gast:";
            // 
            // pK_GastTextBox
            // 
            this.pK_GastTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_gastBindingSource, "PK_Gast", true));
            this.pK_GastTextBox.Location = new System.Drawing.Point(162, 245);
            this.pK_GastTextBox.Name = "pK_GastTextBox";
            this.pK_GastTextBox.Size = new System.Drawing.Size(200, 20);
            this.pK_GastTextBox.TabIndex = 10;
            // 
            // registrierungsdatumLabel
            // 
            registrierungsdatumLabel.AutoSize = true;
            registrierungsdatumLabel.Location = new System.Drawing.Point(50, 275);
            registrierungsdatumLabel.Name = "registrierungsdatumLabel";
            registrierungsdatumLabel.Size = new System.Drawing.Size(106, 13);
            registrierungsdatumLabel.TabIndex = 11;
            registrierungsdatumLabel.Text = "Registrierungsdatum:";
            // 
            // registrierungsdatumDateTimePicker
            // 
            this.registrierungsdatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.casino_gastBindingSource, "Registrierungsdatum", true));
            this.registrierungsdatumDateTimePicker.Location = new System.Drawing.Point(162, 271);
            this.registrierungsdatumDateTimePicker.Name = "registrierungsdatumDateTimePicker";
            this.registrierungsdatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.registrierungsdatumDateTimePicker.TabIndex = 12;
            // 
            // sperrstatusLabel
            // 
            sperrstatusLabel.AutoSize = true;
            sperrstatusLabel.Location = new System.Drawing.Point(50, 302);
            sperrstatusLabel.Name = "sperrstatusLabel";
            sperrstatusLabel.Size = new System.Drawing.Size(63, 13);
            sperrstatusLabel.TabIndex = 13;
            sperrstatusLabel.Text = "Sperrstatus:";
            // 
            // sperrstatusCheckBox
            // 
            this.sperrstatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.casino_gastBindingSource, "Sperrstatus", true));
            this.sperrstatusCheckBox.Location = new System.Drawing.Point(162, 297);
            this.sperrstatusCheckBox.Name = "sperrstatusCheckBox";
            this.sperrstatusCheckBox.Size = new System.Drawing.Size(200, 24);
            this.sperrstatusCheckBox.TabIndex = 14;
            this.sperrstatusCheckBox.Text = "checkBox1";
            this.sperrstatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // vIPLabel
            // 
            vIPLabel.AutoSize = true;
            vIPLabel.Location = new System.Drawing.Point(50, 332);
            vIPLabel.Name = "vIPLabel";
            vIPLabel.Size = new System.Drawing.Size(27, 13);
            vIPLabel.TabIndex = 15;
            vIPLabel.Text = "VIP:";
            // 
            // vIPCheckBox
            // 
            this.vIPCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.casino_gastBindingSource, "VIP", true));
            this.vIPCheckBox.Location = new System.Drawing.Point(162, 327);
            this.vIPCheckBox.Name = "vIPCheckBox";
            this.vIPCheckBox.Size = new System.Drawing.Size(200, 24);
            this.vIPCheckBox.TabIndex = 16;
            this.vIPCheckBox.Text = "checkBox1";
            this.vIPCheckBox.UseVisualStyleBackColor = true;
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(50, 360);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(52, 13);
            vornameLabel.TabIndex = 17;
            vornameLabel.Text = "Vorname:";
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_gastBindingSource, "Vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(162, 357);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(200, 20);
            this.vornameTextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(598, 494);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.adresseTextBox);
            this.Controls.Add(ausweisnummerLabel);
            this.Controls.Add(this.ausweisnummerTextBox);
            this.Controls.Add(geburtsdatumLabel);
            this.Controls.Add(this.geburtsdatumDateTimePicker);
            this.Controls.Add(nachnameLabel);
            this.Controls.Add(this.nachnameTextBox);
            this.Controls.Add(pK_GastLabel);
            this.Controls.Add(this.pK_GastTextBox);
            this.Controls.Add(registrierungsdatumLabel);
            this.Controls.Add(this.registrierungsdatumDateTimePicker);
            this.Controls.Add(sperrstatusLabel);
            this.Controls.Add(this.sperrstatusCheckBox);
            this.Controls.Add(vIPLabel);
            this.Controls.Add(this.vIPCheckBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.casino_gastBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.casino_gastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casino_gastBindingNavigator)).EndInit();
            this.casino_gastBindingNavigator.ResumeLayout(false);
            this.casino_gastBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource casino_gastBindingSource;
        private System.Windows.Forms.BindingNavigator casino_gastBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton casino_gastBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox ausweisnummerTextBox;
        private System.Windows.Forms.DateTimePicker geburtsdatumDateTimePicker;
        private System.Windows.Forms.TextBox nachnameTextBox;
        private System.Windows.Forms.TextBox pK_GastTextBox;
        private System.Windows.Forms.DateTimePicker registrierungsdatumDateTimePicker;
        private System.Windows.Forms.CheckBox sperrstatusCheckBox;
        private System.Windows.Forms.CheckBox vIPCheckBox;
        private System.Windows.Forms.TextBox vornameTextBox;
    }
}

