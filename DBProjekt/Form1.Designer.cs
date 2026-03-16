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
            this.gastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.gastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kameraueberwachungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mitarbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rollenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schichtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sicherheitsvorfallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spielBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaktionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gastBindingNavigator)).BeginInit();
            this.gastBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kameraueberwachungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schichtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicherheitsvorfallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaktionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gastBindingNavigator
            // 
            this.gastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gastBindingNavigator.BindingSource = this.gastBindingSource;
            this.gastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gastBindingNavigatorSaveItem});
            this.gastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gastBindingNavigator.Name = "gastBindingNavigator";
            this.gastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gastBindingNavigator.Size = new System.Drawing.Size(311, 25);
            this.gastBindingNavigator.TabIndex = 0;
            this.gastBindingNavigator.Text = "bindingNavigator1";
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
            // gastBindingSource
            // 
            this.gastBindingSource.DataSource = typeof(DBProjekt.gast);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 22);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gastBindingNavigatorSaveItem
            // 
            this.gastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gastBindingNavigatorSaveItem.Enabled = false;
            this.gastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gastBindingNavigatorSaveItem.Image")));
            this.gastBindingNavigatorSaveItem.Name = "gastBindingNavigatorSaveItem";
            this.gastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gastBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // kameraueberwachungBindingSource
            // 
            this.kameraueberwachungBindingSource.DataSource = typeof(DBProjekt.kameraueberwachung);
            // 
            // mitarbeiterBindingSource
            // 
            this.mitarbeiterBindingSource.DataSource = typeof(DBProjekt.mitarbeiter);
            // 
            // rollenBindingSource
            // 
            this.rollenBindingSource.DataSource = typeof(DBProjekt.rollen);
            // 
            // schichtBindingSource
            // 
            this.schichtBindingSource.DataSource = typeof(DBProjekt.schicht);
            // 
            // sicherheitsvorfallBindingSource
            // 
            this.sicherheitsvorfallBindingSource.DataSource = typeof(DBProjekt.sicherheitsvorfall);
            // 
            // spielBindingSource
            // 
            this.spielBindingSource.DataSource = typeof(DBProjekt.spiel);
            // 
            // transaktionBindingSource
            // 
            this.transaktionBindingSource.DataSource = typeof(DBProjekt.transaktion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(311, 494);
            this.Controls.Add(this.gastBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gastBindingNavigator)).EndInit();
            this.gastBindingNavigator.ResumeLayout(false);
            this.gastBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kameraueberwachungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rollenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schichtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicherheitsvorfallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spielBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaktionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gastBindingSource;
        private System.Windows.Forms.BindingNavigator gastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gastBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource kameraueberwachungBindingSource;
        private System.Windows.Forms.BindingSource mitarbeiterBindingSource;
        private System.Windows.Forms.BindingSource rollenBindingSource;
        private System.Windows.Forms.BindingSource schichtBindingSource;
        private System.Windows.Forms.BindingSource sicherheitsvorfallBindingSource;
        private System.Windows.Forms.BindingSource spielBindingSource;
        private System.Windows.Forms.BindingSource transaktionBindingSource;
    }
}

