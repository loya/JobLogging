namespace JobLogging.Forms
{
    partial class frmAddPermission
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
            this.chkRootNode = new DevExpress.XtraEditors.CheckEdit();
            this.txtPromissionName = new DevExpress.XtraEditors.TextEdit();
            this.lblPromissionName = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chkRootNode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromissionName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRootNode
            // 
            this.chkRootNode.Location = new System.Drawing.Point(49, 16);
            this.chkRootNode.Name = "chkRootNode";
            this.chkRootNode.Properties.Caption = "根节点权限";
            this.chkRootNode.Size = new System.Drawing.Size(94, 19);
            this.chkRootNode.TabIndex = 0;
            // 
            // txtPromissionName
            // 
            this.txtPromissionName.Location = new System.Drawing.Point(119, 48);
            this.txtPromissionName.Name = "txtPromissionName";
            this.txtPromissionName.Size = new System.Drawing.Size(163, 20);
            this.txtPromissionName.TabIndex = 1;
            // 
            // lblPromissionName
            // 
            this.lblPromissionName.Location = new System.Drawing.Point(53, 51);
            this.lblPromissionName.Name = "lblPromissionName";
            this.lblPromissionName.Size = new System.Drawing.Size(60, 14);
            this.lblPromissionName.TabIndex = 2;
            this.lblPromissionName.Text = "权限名称：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(70, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确 定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取 消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 141);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPromissionName);
            this.Controls.Add(this.txtPromissionName);
            this.Controls.Add(this.chkRootNode);
            this.Name = "frmAddPermission";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增权限";
            this.Load += new System.EventHandler(this.frmAddPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkRootNode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPromissionName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit chkRootNode;
        private DevExpress.XtraEditors.TextEdit txtPromissionName;
        private DevExpress.XtraEditors.LabelControl lblPromissionName;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}