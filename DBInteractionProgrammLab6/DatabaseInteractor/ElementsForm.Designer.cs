namespace DatabaseInteractor
{
    partial class ElementsForm
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
            this.Output = new System.Windows.Forms.DataGridView();
            this.UpdateInfoButton = new System.Windows.Forms.Button();
            this.TableCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output.Location = new System.Drawing.Point(12, 41);
            this.Output.Name = "Output";
            this.Output.RowTemplate.Height = 25;
            this.Output.Size = new System.Drawing.Size(776, 397);
            this.Output.TabIndex = 0;
            // 
            // UpdateInfoButton
            // 
            this.UpdateInfoButton.Location = new System.Drawing.Point(198, 12);
            this.UpdateInfoButton.Name = "UpdateInfoButton";
            this.UpdateInfoButton.Size = new System.Drawing.Size(119, 23);
            this.UpdateInfoButton.TabIndex = 1;
            this.UpdateInfoButton.Text = "Обновить данные";
            this.UpdateInfoButton.UseVisualStyleBackColor = true;
            this.UpdateInfoButton.Click += new System.EventHandler(this.UpdateInfoButton_Click);
            // 
            // TableCB
            // 
            this.TableCB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TableCB.Location = new System.Drawing.Point(12, 12);
            this.TableCB.Name = "TableCB";
            this.TableCB.Size = new System.Drawing.Size(180, 23);
            this.TableCB.TabIndex = 2;
            this.TableCB.Text = "Выберите таблицу";
            // 
            // ElementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TableCB);
            this.Controls.Add(this.UpdateInfoButton);
            this.Controls.Add(this.Output);
            this.Name = "ElementsForm";
            this.Text = "ElementsForm";
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView Output;
        private Button UpdateInfoButton;
        private ComboBox TableCB;
    }
}