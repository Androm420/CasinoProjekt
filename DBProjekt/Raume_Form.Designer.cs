namespace DBProjekt
{
    partial class Raume_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raume_Form));
            System.Windows.Forms.Label pK_RaumLabel;
            System.Windows.Forms.Label raumbezeichnungLabel;
            this.casino_raeumeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.casino_raeumeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pK_RaumTextBox = new System.Windows.Forms.TextBox();
            this.raumbezeichnungTextBox = new System.Windows.Forms.TextBox();
            this.casino_raeumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            pK_RaumLabel = new System.Windows.Forms.Label();
            raumbezeichnungLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.casino_raeumeBindingNavigator)).BeginInit();
            this.casino_raeumeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casino_raeumeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // casino_raeumeBindingNavigator
            // 
            this.casino_raeumeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.casino_raeumeBindingNavigator.BindingSource = this.casino_raeumeBindingSource;
            this.casino_raeumeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.casino_raeumeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.casino_raeumeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.casino_raeumeBindingNavigatorSaveItem});
            this.casino_raeumeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.casino_raeumeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.casino_raeumeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.casino_raeumeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.casino_raeumeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.casino_raeumeBindingNavigator.Name = "casino_raeumeBindingNavigator";
            this.casino_raeumeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.casino_raeumeBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.casino_raeumeBindingNavigator.TabIndex = 0;
            this.casino_raeumeBindingNavigator.Text = "bindingNavigator1";
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
            // casino_raeumeBindingNavigatorSaveItem
            // 
            this.casino_raeumeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.casino_raeumeBindingNavigatorSaveItem.Enabled = false;
            this.casino_raeumeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("casino_raeumeBindingNavigatorSaveItem.Image")));
            this.casino_raeumeBindingNavigatorSaveItem.Name = "casino_raeumeBindingNavigatorSaveItem";
            this.casino_raeumeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.casino_raeumeBindingNavigatorSaveItem.Text = "Daten speichern";
            // 
            // pK_RaumLabel
            // 
            pK_RaumLabel.AutoSize = true;
            pK_RaumLabel.Location = new System.Drawing.Point(166, 160);
            pK_RaumLabel.Name = "pK_RaumLabel";
            pK_RaumLabel.Size = new System.Drawing.Size(55, 13);
            pK_RaumLabel.TabIndex = 1;
            pK_RaumLabel.Text = "PK Raum:";
            // 
            // pK_RaumTextBox
            // 
            this.pK_RaumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_raeumeBindingSource, "PK_Raum", true));
            this.pK_RaumTextBox.Location = new System.Drawing.Point(271, 157);
            this.pK_RaumTextBox.Name = "pK_RaumTextBox";
            this.pK_RaumTextBox.Size = new System.Drawing.Size(100, 20);
            this.pK_RaumTextBox.TabIndex = 2;
            // 
            // raumbezeichnungLabel
            // 
            raumbezeichnungLabel.AutoSize = true;
            raumbezeichnungLabel.Location = new System.Drawing.Point(166, 186);
            raumbezeichnungLabel.Name = "raumbezeichnungLabel";
            raumbezeichnungLabel.Size = new System.Drawing.Size(99, 13);
            raumbezeichnungLabel.TabIndex = 3;
            raumbezeichnungLabel.Text = "Raumbezeichnung:";
            // 
            // raumbezeichnungTextBox
            // 
            this.raumbezeichnungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.casino_raeumeBindingSource, "Raumbezeichnung", true));
            this.raumbezeichnungTextBox.Location = new System.Drawing.Point(271, 183);
            this.raumbezeichnungTextBox.Name = "raumbezeichnungTextBox";
            this.raumbezeichnungTextBox.Size = new System.Drawing.Size(100, 20);
            this.raumbezeichnungTextBox.TabIndex = 4;
            // 
            // casino_raeumeBindingSource
            // 
            this.casino_raeumeBindingSource.DataSource = typeof(DBProjekt.casino_raeume);
            // 
            // Raume_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pK_RaumLabel);
            this.Controls.Add(this.pK_RaumTextBox);
            this.Controls.Add(raumbezeichnungLabel);
            this.Controls.Add(this.raumbezeichnungTextBox);
            this.Controls.Add(this.casino_raeumeBindingNavigator);
            this.Name = "Raume_Form";
            this.Text = "Raume_Form";
            ((System.ComponentModel.ISupportInitialize)(this.casino_raeumeBindingNavigator)).EndInit();
            this.casino_raeumeBindingNavigator.ResumeLayout(false);
            this.casino_raeumeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.casino_raeumeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource casino_raeumeBindingSource;
        private System.Windows.Forms.BindingNavigator casino_raeumeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton casino_raeumeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pK_RaumTextBox;
        private System.Windows.Forms.TextBox raumbezeichnungTextBox;
    }
}