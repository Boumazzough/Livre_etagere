namespace Livre_etagere
{
    partial class Form5
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.biblioDataSet = new Livre_etagere.BiblioDataSet();
            this.etagereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etagereTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.etagereTableAdapter();
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livreTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.livreTableAdapter();
            this.tableAdapterManager = new Livre_etagere.BiblioDataSetTableAdapters.TableAdapterManager();
            this.livreComboBox = new System.Windows.Forms.ComboBox();
            this.etagereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etagereComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(196, 144);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Code Livre";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(196, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Numero étagère";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(322, 282);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(84, 41);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "Precedent";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(425, 282);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(84, 41);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroTile2.TabIndex = 5;
            this.metroTile2.Text = "Retirer";
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
            // livreBindingSource
            // 
            this.livreBindingSource.DataMember = "etagere_livre";
            this.livreBindingSource.DataSource = this.etagereBindingSource;
            // 
            // livreTableAdapter
            // 
            this.livreTableAdapter.ClearBeforeFill = true;
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
            this.livreComboBox.DataSource = this.livreBindingSource;
            this.livreComboBox.DisplayMember = "code";
            this.livreComboBox.FormattingEnabled = true;
            this.livreComboBox.Location = new System.Drawing.Point(408, 144);
            this.livreComboBox.Name = "livreComboBox";
            this.livreComboBox.Size = new System.Drawing.Size(121, 21);
            this.livreComboBox.TabIndex = 5;
            this.livreComboBox.ValueMember = "Id";
            // 
            // etagereBindingSource1
            // 
            this.etagereBindingSource1.DataMember = "etagere";
            this.etagereBindingSource1.DataSource = this.biblioDataSet;
            // 
            // etagereComboBox
            // 
            this.etagereComboBox.DataSource = this.etagereBindingSource1;
            this.etagereComboBox.DisplayMember = "numero";
            this.etagereComboBox.FormattingEnabled = true;
            this.etagereComboBox.Location = new System.Drawing.Point(408, 202);
            this.etagereComboBox.Name = "etagereComboBox";
            this.etagereComboBox.Size = new System.Drawing.Size(121, 21);
            this.etagereComboBox.TabIndex = 5;
            this.etagereComboBox.ValueMember = "Id";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 464);
            this.Controls.Add(this.etagereComboBox);
            this.Controls.Add(this.livreComboBox);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form5";
            this.Text = "Retirer un livre d\'une étagère";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource etagereBindingSource;
        private BiblioDataSetTableAdapters.etagereTableAdapter etagereTableAdapter;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private BiblioDataSetTableAdapters.livreTableAdapter livreTableAdapter;
        private BiblioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox livreComboBox;
        private System.Windows.Forms.BindingSource etagereBindingSource1;
        private System.Windows.Forms.ComboBox etagereComboBox;
    }
}