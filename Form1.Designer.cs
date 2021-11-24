
namespace Address2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label 名前Label;
            System.Windows.Forms.Label 住所Label;
            System.Windows.Forms.Label 電話番号Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.address2TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adress2DataSet = new Address2.adress2DataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.住所TextBox = new System.Windows.Forms.TextBox();
            this.電話番号TextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.address2TableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.address2TableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.address2TableTableAdapter = new Address2.adress2DataSetTableAdapters.Address2TableTableAdapter();
            this.tableAdapterManager = new Address2.adress2DataSetTableAdapters.TableAdapterManager();
            iDLabel = new System.Windows.Forms.Label();
            名前Label = new System.Windows.Forms.Label();
            住所Label = new System.Windows.Forms.Label();
            電話番号Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.address2TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adress2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.address2TableBindingNavigator)).BeginInit();
            this.address2TableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(48, 54);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(18, 12);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // 名前Label
            // 
            名前Label.AutoSize = true;
            名前Label.Location = new System.Drawing.Point(209, 54);
            名前Label.Name = "名前Label";
            名前Label.Size = new System.Drawing.Size(31, 12);
            名前Label.TabIndex = 3;
            名前Label.Text = "名前:";
            // 
            // 住所Label
            // 
            住所Label.AutoSize = true;
            住所Label.Location = new System.Drawing.Point(35, 103);
            住所Label.Name = "住所Label";
            住所Label.Size = new System.Drawing.Size(31, 12);
            住所Label.TabIndex = 5;
            住所Label.Text = "住所:";
            // 
            // 電話番号Label
            // 
            電話番号Label.AutoSize = true;
            電話番号Label.Location = new System.Drawing.Point(11, 179);
            電話番号Label.Name = "電話番号Label";
            電話番号Label.Size = new System.Drawing.Size(55, 12);
            電話番号Label.TabIndex = 7;
            電話番号Label.Text = "電話番号:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.address2TableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(72, 51);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 19);
            this.iDTextBox.TabIndex = 2;
            this.iDTextBox.TextChanged += new System.EventHandler(this.iDTextBox_TextChanged);
            this.iDTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iDTextBox_Validating);
            this.iDTextBox.Validated += new System.EventHandler(this.iDTextBox_Validated);
            // 
            // address2TableBindingSource
            // 
            this.address2TableBindingSource.DataMember = "Address2Table";
            this.address2TableBindingSource.DataSource = this.adress2DataSet;
            // 
            // adress2DataSet
            // 
            this.adress2DataSet.DataSetName = "adress2DataSet";
            this.adress2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.address2TableBindingSource, "名前", true));
            this.nameTextBox.Location = new System.Drawing.Point(246, 51);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(148, 19);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // 住所TextBox
            // 
            this.住所TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.address2TableBindingSource, "住所", true));
            this.住所TextBox.Location = new System.Drawing.Point(72, 100);
            this.住所TextBox.Multiline = true;
            this.住所TextBox.Name = "住所TextBox";
            this.住所TextBox.Size = new System.Drawing.Size(322, 52);
            this.住所TextBox.TabIndex = 6;
            this.住所TextBox.TextChanged += new System.EventHandler(this.住所TextBox_TextChanged);
            // 
            // 電話番号TextBox
            // 
            this.電話番号TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.address2TableBindingSource, "電話番号", true));
            this.電話番号TextBox.Location = new System.Drawing.Point(72, 176);
            this.電話番号TextBox.Name = "電話番号TextBox";
            this.電話番号TextBox.Size = new System.Drawing.Size(135, 19);
            this.電話番号TextBox.TabIndex = 8;
            this.電話番号TextBox.TextChanged += new System.EventHandler(this.電話番号TextBox_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
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
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // address2TableBindingNavigatorSaveItem
            // 
            this.address2TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.address2TableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("address2TableBindingNavigatorSaveItem.Image")));
            this.address2TableBindingNavigatorSaveItem.Name = "address2TableBindingNavigatorSaveItem";
            this.address2TableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.address2TableBindingNavigatorSaveItem.Text = "データの保存";
            // 
            // address2TableBindingNavigator
            // 
            this.address2TableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.address2TableBindingNavigator.BindingSource = this.address2TableBindingSource;
            this.address2TableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.address2TableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.address2TableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.address2TableBindingNavigatorSaveItem});
            this.address2TableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.address2TableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.address2TableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.address2TableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.address2TableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.address2TableBindingNavigator.Name = "address2TableBindingNavigator";
            this.address2TableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.address2TableBindingNavigator.Size = new System.Drawing.Size(424, 25);
            this.address2TableBindingNavigator.TabIndex = 0;
            this.address2TableBindingNavigator.Text = "bindingNavigator1";
            // 
            // address2TableTableAdapter
            // 
            this.address2TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Address2TableTableAdapter = this.address2TableTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Address2.adress2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 230);
            this.Controls.Add(電話番号Label);
            this.Controls.Add(this.電話番号TextBox);
            this.Controls.Add(住所Label);
            this.Controls.Add(this.住所TextBox);
            this.Controls.Add(名前Label);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.address2TableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Address";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.address2TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adress2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.address2TableBindingNavigator)).EndInit();
            this.address2TableBindingNavigator.ResumeLayout(false);
            this.address2TableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private adress2DataSet adress2DataSet;
        private System.Windows.Forms.BindingSource address2TableBindingSource;
        private adress2DataSetTableAdapters.Address2TableTableAdapter address2TableTableAdapter;
        private adress2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox 住所TextBox;
        private System.Windows.Forms.TextBox 電話番号TextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingNavigator address2TableBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton address2TableBindingNavigatorSaveItem;
    }
}

