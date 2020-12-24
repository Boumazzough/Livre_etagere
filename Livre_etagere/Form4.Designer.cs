namespace Livre_etagere
{
    partial class Form4
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
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.biblioDataSet = new Livre_etagere.BiblioDataSet();
            this.etagereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etagereTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.etagereTableAdapter();
            this.etagerelivreBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.livreTableAdapter = new Livre_etagere.BiblioDataSetTableAdapters.livreTableAdapter();
            this.etagerelivreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioDataSet1 = new Livre_etagere.BiblioDataSet();
            this.etagereBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etagerelivreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.livreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Livre_etagere.BiblioDataSetTableAdapters.TableAdapterManager();
            this.livreComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.White;
            this.metroLabel1.ForeColor = System.Drawing.Color.Green;
            this.metroLabel1.Location = new System.Drawing.Point(269, 147);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Code de Livre";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Green;
            this.metroLabel2.Location = new System.Drawing.Point(269, 206);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Numero Etagere";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(350, 276);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 39);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Precedent";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(459, 276);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(85, 39);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 3;
            this.metroTile2.Text = "Remettre";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.DataSource = this.etagereBindingSource1;
            this.metroComboBox2.DisplayMember = "numero";
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(445, 206);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 5;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.ValueMember = "Id";
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
            // livreTableAdapter
            // 
            this.livreTableAdapter.ClearBeforeFill = true;
            // 
            // etagerelivreBindingSource
            // 
            this.etagerelivreBindingSource.DataMember = "etagere_livre";
            this.etagerelivreBindingSource.DataSource = this.etagereBindingSource;
            // 
            // biblioDataSet1
            // 
            this.biblioDataSet1.DataSetName = "BiblioDataSet";
            this.biblioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etagereBindingSource1
            // 
            this.etagereBindingSource1.DataMember = "etagere";
            this.etagereBindingSource1.DataSource = this.biblioDataSet1;
            // 
            // etagerelivreBindingSource1
            // 
            this.etagerelivreBindingSource1.DataMember = "etagere_livre";
            this.etagerelivreBindingSource1.DataSource = this.etagereBindingSource1;
            // 
            // livreBindingSource
            // 
            this.livreBindingSource.DataMember = "etagere_livre";
            this.livreBindingSource.DataSource = this.etagereBindingSource1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.etagereTableAdapter = null;
            this.tableAdapterManager.livreTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Livre_etagere.BiblioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // livreComboBox
            // 
            this.livreComboBox.DataSource = this.etagerelivreBindingSource1;
            this.livreComboBox.DisplayMember = "code";
            this.livreComboBox.FormattingEnabled = true;
            this.livreComboBox.Location = new System.Drawing.Point(445, 147);
            this.livreComboBox.Name = "livreComboBox";
            this.livreComboBox.Size = new System.Drawing.Size(121, 21);
            this.livreComboBox.TabIndex = 6;
            this.livreComboBox.ValueMember = "Id";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 464);
            this.Controls.Add(this.livreComboBox);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "Form4";
            this.Text = "Remettre un livre dans  une etagere";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagereBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etagerelivreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private BiblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource etagereBindingSource;
        private BiblioDataSetTableAdapters.etagereTableAdapter etagereTableAdapter;
        private BiblioDataSetTableAdapters.livreTableAdapter livreTableAdapter;
        private System.Windows.Forms.BindingSource etagerelivreBindingSource5;
        private System.Windows.Forms.BindingSource etagerelivreBindingSource;
        private BiblioDataSet biblioDataSet1;
        private System.Windows.Forms.BindingSource etagereBindingSource1;
        private System.Windows.Forms.BindingSource etagerelivreBindingSource1;
        private System.Windows.Forms.BindingSource livreBindingSource;
        private BiblioDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox livreComboBox;
    }
}