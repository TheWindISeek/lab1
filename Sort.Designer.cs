namespace lab1
{
    partial class Sort
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
            this.bno = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.preSort = new System.Windows.Forms.TextBox();
            this.thenSort = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bno
            // 
            this.bno.AutoSize = true;
            this.bno.Location = new System.Drawing.Point(101, 51);
            this.bno.Name = "bno";
            this.bno.Size = new System.Drawing.Size(233, 15);
            this.bno.TabIndex = 0;
            this.bno.Text = "数组空间为5，请依次输入5个数字";
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Location = new System.Drawing.Point(101, 102);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(120, 15);
            this.no.TabIndex = 1;
            this.no.Text = "请输入第1个元素";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "排序前数组序列:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "排序后数组序列:";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(243, 102);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(123, 25);
            this.input.TabIndex = 4;
            // 
            // preSort
            // 
            this.preSort.Location = new System.Drawing.Point(174, 193);
            this.preSort.Name = "preSort";
            this.preSort.Size = new System.Drawing.Size(255, 25);
            this.preSort.TabIndex = 5;
            // 
            // thenSort
            // 
            this.thenSort.Location = new System.Drawing.Point(174, 308);
            this.thenSort.Name = "thenSort";
            this.thenSort.Size = new System.Drawing.Size(268, 25);
            this.thenSort.TabIndex = 6;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(466, 102);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(466, 264);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "排序";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sort_Click);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.add);
            this.Controls.Add(this.thenSort);
            this.Controls.Add(this.preSort);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.no);
            this.Controls.Add(this.bno);
            this.Name = "Sort";
            this.Text = "sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bno;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox preSort;
        private System.Windows.Forms.TextBox thenSort;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sortButton;
    }
}