namespace DatabaseInteractor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActCB = new System.Windows.Forms.ComboBox();
            this.TableCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IDElementCB = new System.Windows.Forms.ComboBox();
            this.ElementLabel = new System.Windows.Forms.Label();
            this.InputGrid = new System.Windows.Forms.DataGridView();
            this.Output = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // ActCB
            // 
            this.ActCB.FormattingEnabled = true;
            this.ActCB.Items.AddRange(new object[] {
            "Посмотреть элементы",
            "Добавить элементы",
            "Редактировать элементы",
            "Удалить элементы"});
            this.ActCB.Location = new System.Drawing.Point(79, 12);
            this.ActCB.Name = "ActCB";
            this.ActCB.Size = new System.Drawing.Size(163, 23);
            this.ActCB.TabIndex = 4;
            this.ActCB.SelectedIndexChanged += new System.EventHandler(this.ActCB_SelectedIndexChanged);
            // 
            // TableCB
            // 
            this.TableCB.FormattingEnabled = true;
            this.TableCB.Location = new System.Drawing.Point(79, 41);
            this.TableCB.Name = "TableCB";
            this.TableCB.Size = new System.Drawing.Size(121, 23);
            this.TableCB.TabIndex = 5;
            this.TableCB.SelectedIndexChanged += new System.EventHandler(this.TableCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Таблица:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Действие:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Действие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IDElementCB
            // 
            this.IDElementCB.FormattingEnabled = true;
            this.IDElementCB.Location = new System.Drawing.Point(79, 70);
            this.IDElementCB.Name = "IDElementCB";
            this.IDElementCB.Size = new System.Drawing.Size(59, 23);
            this.IDElementCB.TabIndex = 9;
            // 
            // ElementLabel
            // 
            this.ElementLabel.AutoSize = true;
            this.ElementLabel.Location = new System.Drawing.Point(17, 73);
            this.ElementLabel.Name = "ElementLabel";
            this.ElementLabel.Size = new System.Drawing.Size(57, 15);
            this.ElementLabel.TabIndex = 10;
            this.ElementLabel.Text = "Элемент:";
            // 
            // InputGrid
            // 
            this.InputGrid.AllowUserToAddRows = false;
            this.InputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputGrid.Location = new System.Drawing.Point(12, 99);
            this.InputGrid.Name = "InputGrid";
            this.InputGrid.RowTemplate.Height = 25;
            this.InputGrid.Size = new System.Drawing.Size(644, 108);
            this.InputGrid.TabIndex = 11;
            // 
            // Output
            // 
            this.Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output.Location = new System.Drawing.Point(12, 99);
            this.Output.Name = "Output";
            this.Output.RowTemplate.Height = 25;
            this.Output.Size = new System.Drawing.Size(644, 208);
            this.Output.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 334);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.InputGrid);
            this.Controls.Add(this.ElementLabel);
            this.Controls.Add(this.IDElementCB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableCB);
            this.Controls.Add(this.ActCB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox ActCB;
        private ComboBox TableCB;
        private Label label1;
        private Label label2;
        private Button button1;
        private ComboBox IDElementCB;
        private Label ElementLabel;
        private DataGridView InputGrid;
        private DataGridView Output;
    }
}