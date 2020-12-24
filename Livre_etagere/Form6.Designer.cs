namespace Livre_etagere
{
    partial class Form6
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.biblioDataSet = new Livre_etagere.BiblioDataSet();
            this.etagereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etagereTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.etagereTableAdapter();
            this.etagerelivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livreTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.livreTableAdapter();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Livre_etagere.BiblioDataSetTableAdapters.TableAdapterManager();
            this.livreComboBox = new System.Windows.Forms.ComboBox();
            this.etagerelivreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livreComboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.metroLabel1.Location = new System.Drawing.Point(240, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Numero étagère";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(240, 184);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Livre a remplacer";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(240, 238);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(95, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Code du Livre ";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.etagereBindingSource;
            this.metroComboBox1.DisplayMember = "numero";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(419, 138);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "Id";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(320, 311);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(89, 41);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 6;
            this.metroTile1.Text = "Precednt";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(433, 311);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(88, 41);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Remplacer";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // biblioDataSet
            // 
            this.biblioDataSet.DataSetName = "BiblioDataSet";
            this.biblioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etagereBindingSource
            // 
            this.etagereBindingSource.DataMember = "etagere";
            this.etagereBindingSource.DataSource = this.biblioDataSet;
            // 
            // etagereTableAdapter
            // 
            this.etagereTableAdapter.ClearBeforeFill = true;
            // 
            // etagerelivreBindingSource
            // 
            this.etagerelivreBindingSource.DataMember = "etagere_livre";
            this.etagerelivreBindingSource.DataSource = this.etagereBindingSource;
            // 
            // livreTableAdapter
            // 
            this.livreTableAdapter.ClearBeforeFill = true;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataMember = "etagere_livre";
            this.livreBindingSource.DataSource = this.etagereBindingSource;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.etagereTableAdapter = this.etagereTableAdapter;
            this.tableAdapterManager.livreTableAdapter = this.livreTableAdapter;
            this.tableAdapterManager.UpdateOrder = Livre_etagere.BiblioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livreComboBox
            // 
            this.livreComboBox.DataSource = this.etagerelivreBindingSource1;
            this.livreComboBox.DisplayMember = "code";
            this.livreComboBox.FormattingEnabled = true;
            this.livreComboBox.Location = new System.Drawing.Point(419, 236);
            this.livreComboBox.Name = "livreComboBox";
            this.livreComboBox.Size = new System.Drawing.Size(121, 21);
            this.livreComboBox.TabIndex = 7;
            this.livreComboBox.ValueMember = "Id";
            // 
            // etagerelivreBindingSource1
            // 
            this.etagerelivreBindingSource1.DataMember = "etagere_livre";
            this.etagerelivreBindingSource1.DataSource = this.etagereBindingSource;
            // 
            // livreBindingSource1
            // 
            this.livreBindingSource1.DataMember = "etagere_livre";
            this.livreBindingSource1.DataSource = this.etagereBindingSource;
            // 
            // livreComboBox1
            // 
            this.livreComboBox1.DataSource = this.livreBindingSource1;
            this.livreComboBox1.DisplayMember = "code";
            this.livreComboBox1.FormattingEnabled = true;
            this.livreComboBox1.Location = new System.Drawing.Point(419, 193);
            this.livreComboBox1.Name = "livreComboBox1";
            this.livreComboBox1.Size = new System.Drawing.Size(121, 21);
            this.livreComboBox1.TabIndex = 7;
            this.livreComboBox1.ValueMember = "Id";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 464);
            this.Controls.Add(this.livreComboBox1);
            this.Controls.Add(this.livreComboBox);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form6";
            this.Text = "Remplacer un livre par un autre d\'une étagère";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource etagereBindingSource;
        private BiblioDataSetTableAdapters.etagereTableAdapter etagereTableAdapter;
        private System.Windows.Forms.BindingSource etagerelivreBindingSource;
        private BiblioDataSetTableAdapters.livreTableAdapter livreTableAdapter;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private BiblioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox livreComboBox;
        private System.Windows.Forms.BindingSource etagerelivreBindingSource1;
        private System.Windows.Forms.BindingSource livreBindingSource1;
        private System.Windows.Forms.ComboBox livreComboBox1;
    }
}