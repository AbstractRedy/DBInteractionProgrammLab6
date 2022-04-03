namespace DatabaseInteractor
{
    partial class EditForm
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
            this.InputGrid = new System.Windows.Forms.DataGridView();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.TableCB = new System.Windows.Forms.ComboBox();
            this.IDElementCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InputGrid
            // 
            this.InputGrid.AllowUserToAddRows = false;
            this.InputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputGrid.Location = new System.Drawing.Point(12, 63);
            this.InputGrid.Name = "InputGrid";
            this.InputGrid.RowTemplate.Height = 25;
            this.InputGrid.Size = new System.Drawing.Size(611, 123);
            this.InputGrid.TabIndex = 0;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(391, 5);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(166, 52);
            this.ChangeButton.TabIndex = 1;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TableCB
            // 
            this.TableCB.FormattingEnabled = true;
            this.TableCB.Location = new System.Drawing.Point(264, 6);
            this.TableCB.Name = "TableCB";
            this.TableCB.Size = new System.Drawing.Size(121, 23);
            this.TableCB.TabIndex = 2;
            this.TableCB.SelectedIndexChanged += new System.EventHandler(this.TableCB_SelectedIndexChanged);
            // 
            // IDElementCB
            // 
            this.IDElementCB.FormattingEnabled = true;
            this.IDElementCB.Location = new System.Drawing.Point(103, 34);
            this.IDElementCB.Name = "IDElementCB";
            this.IDElementCB.Size = new System.Drawing.Size(59, 23);
            this.IDElementCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица, в которой будет изменена строка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Код элемента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "\"null\" удалит значение из ячейки";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDElementCB);
            this.Controls.Add(this.TableCB);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.InputGrid);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView InputGrid;
        private Button ChangeButton;
        private ComboBox TableCB;
        private ComboBox IDElementCB;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}