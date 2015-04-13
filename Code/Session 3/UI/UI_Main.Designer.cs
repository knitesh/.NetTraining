namespace UI
{
    partial class UI_Main
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
            this.btnDataType = new System.Windows.Forms.Button();
            this.btnGenerics = new System.Windows.Forms.Button();
            this.btnEncapsulation = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnPolymorphism = new System.Windows.Forms.Button();
            this.btnControlFlow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDataType
            // 
            this.btnDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDataType.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDataType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDataType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDataType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDataType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDataType.Location = new System.Drawing.Point(96, 133);
            this.btnDataType.Name = "btnDataType";
            this.btnDataType.Size = new System.Drawing.Size(189, 52);
            this.btnDataType.TabIndex = 0;
            this.btnDataType.Text = "DataType";
            this.btnDataType.UseVisualStyleBackColor = false;
            this.btnDataType.Click += new System.EventHandler(this.btnDataType_Click);
            // 
            // btnGenerics
            // 
            this.btnGenerics.Location = new System.Drawing.Point(96, 268);
            this.btnGenerics.Name = "btnGenerics";
            this.btnGenerics.Size = new System.Drawing.Size(189, 52);
            this.btnGenerics.TabIndex = 6;
            this.btnGenerics.Text = "Generics";
            this.btnGenerics.UseVisualStyleBackColor = true;
            this.btnGenerics.Click += new System.EventHandler(this.btnGenerics_Click);
            // 
            // btnEncapsulation
            // 
            this.btnEncapsulation.Location = new System.Drawing.Point(96, 433);
            this.btnEncapsulation.Name = "btnEncapsulation";
            this.btnEncapsulation.Size = new System.Drawing.Size(189, 52);
            this.btnEncapsulation.TabIndex = 7;
            this.btnEncapsulation.Text = "Encapsulation";
            this.btnEncapsulation.UseVisualStyleBackColor = true;
            this.btnEncapsulation.Click += new System.EventHandler(this.btnEncapsulation_Click);
            // 
            // btnInterface
            // 
            this.btnInterface.Location = new System.Drawing.Point(396, 268);
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.Size = new System.Drawing.Size(189, 52);
            this.btnInterface.TabIndex = 8;
            this.btnInterface.Text = "Interface";
            this.btnInterface.UseVisualStyleBackColor = true;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click);
            // 
            // btnPolymorphism
            // 
            this.btnPolymorphism.Location = new System.Drawing.Point(396, 433);
            this.btnPolymorphism.Name = "btnPolymorphism";
            this.btnPolymorphism.Size = new System.Drawing.Size(189, 52);
            this.btnPolymorphism.TabIndex = 9;
            this.btnPolymorphism.Text = "Polymorphism";
            this.btnPolymorphism.UseVisualStyleBackColor = true;
            this.btnPolymorphism.Click += new System.EventHandler(this.btnPolymorphism_Click);
            // 
            // btnControlFlow
            // 
            this.btnControlFlow.Location = new System.Drawing.Point(396, 133);
            this.btnControlFlow.Name = "btnControlFlow";
            this.btnControlFlow.Size = new System.Drawing.Size(189, 52);
            this.btnControlFlow.TabIndex = 10;
            this.btnControlFlow.Text = "ControlFlow";
            this.btnControlFlow.UseVisualStyleBackColor = true;
            this.btnControlFlow.Click += new System.EventHandler(this.btnControlFlow_Click);
            // 
            // UI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(723, 655);
            this.Controls.Add(this.btnControlFlow);
            this.Controls.Add(this.btnPolymorphism);
            this.Controls.Add(this.btnInterface);
            this.Controls.Add(this.btnEncapsulation);
            this.Controls.Add(this.btnGenerics);
            this.Controls.Add(this.btnDataType);
            this.MaximizeBox = false;
            this.Name = "UI_Main";
            this.Text = "UI_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataType;
        private System.Windows.Forms.Button btnGenerics;
        private System.Windows.Forms.Button btnEncapsulation;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnPolymorphism;
        private System.Windows.Forms.Button btnControlFlow;
    }
}