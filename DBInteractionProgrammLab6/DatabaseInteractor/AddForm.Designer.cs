namespace DatabaseInteractor
{
    partial class AddForm
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
            this.AEButton = new System.Windows.Forms.Button();
            this.INSERTINTO = new System.Windows.Forms.Label();
            this.TableCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AEButton
            // 
            this.AEButton.Location = new System.Drawing.Point(11, 185);
            this.AEButton.Name = "AEButton";
            this.AEButton.Size = new System.Drawing.Size(120, 23);
            this.AEButton.TabIndex = 0;
            this.AEButton.Text = "Добавить Элемент";
            this.AEButton.UseVisualStyleBackColor = true;
            this.AEButton.Click += new System.EventHandler(this.AEButton_Click);
            // 
            // INSERTINTO
            // 
            this.INSERTINTO.AutoSize = true;
            this.INSERTINTO.Location = new System.Drawing.Point(12, 9);
            this.INSERTINTO.Name = "INSERTINTO";
            this.INSERTINTO.Size = new System.Drawing.Size(270, 15);
            this.INSERTINTO.TabIndex = 1;
            this.INSERTINTO.Text = "Таблица, в которую будут добавлены значения:";
            // 
            // TableCB
            // 
            this.TableCB.FormattingEnabled = true;
            this.TableCB.Location = new System.Drawing.Point(11, 27);
            this.TableCB.Name = "TableCB";
            this.TableCB.Size = new System.Drawing.Size(121, 23);
            this.TableCB.TabIndex = 2;
            this.TableCB.SelectedIndexChanged += new System.EventHandler(this.TableCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите значения столбцы";
            // 
            // InputGrid
            // 
            this.InputGrid.AllowUserToAddRows = false;
            this.InputGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputGrid.Location = new System.Drawing.Point(12, 71);
            this.InputGrid.Name = "InputGrid";
            this.InputGrid.RowTemplate.Height = 25;
            this.InputGrid.Size = new System.Drawing.Size(656, 108);
            this.InputGrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "\"null\" задаст нулевое значение";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableCB);
            this.Controls.Add(this.INSERTINTO);
            this.Controls.Add(this.AEButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AEButton;
        private Label INSERTINTO;
        private ComboBox TableCB;
        private Label label1;
        private DataGridView InputGrid;
        private Label label3;
    }
}