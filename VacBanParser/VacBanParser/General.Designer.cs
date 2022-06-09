
namespace VacBanParser
{
    partial class General
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAccList = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.pbGraph = new System.Windows.Forms.PictureBox();
            this.tbCfg = new System.Windows.Forms.TextBox();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccList
            // 
            this.btnAccList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAccList.ForeColor = System.Drawing.Color.White;
            this.btnAccList.Location = new System.Drawing.Point(678, 11);
            this.btnAccList.Name = "btnAccList";
            this.btnAccList.Size = new System.Drawing.Size(94, 27);
            this.btnAccList.TabIndex = 0;
            this.btnAccList.Text = "Acc List";
            this.btnAccList.UseVisualStyleBackColor = true;
            this.btnAccList.Click += new System.EventHandler(this.btnAccList_Click);
            // 
            // btnParse
            // 
            this.btnParse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnParse.ForeColor = System.Drawing.Color.White;
            this.btnParse.Location = new System.Drawing.Point(653, 523);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(119, 26);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse and Save";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // pbGraph
            // 
            this.pbGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGraph.Location = new System.Drawing.Point(0, 0);
            this.pbGraph.Name = "pbGraph";
            this.pbGraph.Size = new System.Drawing.Size(784, 561);
            this.pbGraph.TabIndex = 3;
            this.pbGraph.TabStop = false;
            // 
            // tbCfg
            // 
            this.tbCfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbCfg.Enabled = false;
            this.tbCfg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.tbCfg.ForeColor = System.Drawing.Color.White;
            this.tbCfg.Location = new System.Drawing.Point(12, 11);
            this.tbCfg.Name = "tbCfg";
            this.tbCfg.Size = new System.Drawing.Size(660, 27);
            this.tbCfg.TabIndex = 4;
            this.tbCfg.Text = "C:\\VacBan Parser";
            // 
            // dgvMatrix
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.NullValue = null;
            this.dgvMatrix.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMatrix.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvMatrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.link,
            this.vacStatus,
            this.comment});
            this.dgvMatrix.GridColor = System.Drawing.Color.White;
            this.dgvMatrix.Location = new System.Drawing.Point(12, 70);
            this.dgvMatrix.Name = "dgvMatrix";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.dgvMatrix.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvMatrix.Size = new System.Drawing.Size(594, 448);
            this.dgvMatrix.TabIndex = 5;
            // 
            // data
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle11;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.data.Width = 70;
            // 
            // link
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.link.DefaultCellStyle = dataGridViewCellStyle12;
            this.link.HeaderText = "Link";
            this.link.Name = "link";
            this.link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.link.Width = 250;
            // 
            // vacStatus
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            this.vacStatus.DefaultCellStyle = dataGridViewCellStyle13;
            this.vacStatus.HeaderText = "Vac Status";
            this.vacStatus.Name = "vacStatus";
            this.vacStatus.ReadOnly = true;
            this.vacStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vacStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.vacStatus.Width = 80;
            // 
            // comment
            // 
            this.comment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            this.comment.DefaultCellStyle = dataGridViewCellStyle14;
            this.comment.HeaderText = "Comment";
            this.comment.Name = "comment";
            this.comment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(678, 44);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.tbCfg);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.btnAccList);
            this.Controls.Add(this.pbGraph);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VacBan Parser";
            ((System.ComponentModel.ISupportInitialize)(this.pbGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccList;
        private System.Windows.Forms.Button btnParse;
        public System.Windows.Forms.PictureBox pbGraph;
        private System.Windows.Forms.TextBox tbCfg;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn link;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    }
}

