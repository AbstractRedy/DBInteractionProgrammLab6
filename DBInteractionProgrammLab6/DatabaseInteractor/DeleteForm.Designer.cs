namespace DatabaseInteractor
{
    partial class DeleteForm
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
            this.DeleteElement = new System.Windows.Forms.Button();
            this.TableCB = new System.Windows.Forms.ComboBox();
            this.IDElementCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteElement
            // 
            this.DeleteElement.Location = new System.Drawing.Point(12, 100);
            this.DeleteElement.Name = "DeleteElement";
            this.DeleteElement.Size = new System.Drawing.Size(229, 23);
            this.DeleteElement.TabIndex = 0;
            this.DeleteElement.Text = "Удалить элемент";
            this.DeleteElement.UseVisualStyleBackColor = true;
            this.DeleteElement.Click += new System.EventHandler(this.DeleteElement_Click);
            // 
            // TableCB
            // 
            this.TableCB.FormattingEnabled = true;
            this.TableCB.Location = new System.Drawing.Point(12, 27);
            this.TableCB.Name = "TableCB";
            this.TableCB.Size = new System.Drawing.Size(121, 23);
            this.TableCB.TabIndex = 1;
            this.TableCB.SelectedIndexChanged += new System.EventHandler(this.TableCB_SelectedIndexChanged);
            // 
            // IDElementCB
            // 
            this.IDElementCB.FormattingEnabled = true;
            this.IDElementCB.Location = new System.Drawing.Point(12, 71);
            this.IDElementCB.Name = "IDElementCB";
            this.IDElementCB.Size = new System.Drawing.Size(121, 23);
            this.IDElementCB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Таблица, из которой удаляется элемент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код элемента:";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDElementCB);
            this.Controls.Add(this.TableCB);
            this.Controls.Add(this.DeleteElement);
            this.Name = "DeleteForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DeleteElement;
        private ComboBox TableCB;
        private ComboBox IDElementCB;
        private Label label1;
        private Label label2;
    }
}