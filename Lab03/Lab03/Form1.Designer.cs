namespace Lab03
{
    partial class Form1
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
            this.pointButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.drawPolygonButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dxdyButton = new System.Windows.Forms.Button();
            this.scaleButton = new System.Windows.Forms.Button();
            this.rotateButton = new System.Windows.Forms.Button();
            this.dxTextBox = new System.Windows.Forms.TextBox();
            this.dyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pointXTextBox = new System.Windows.Forms.TextBox();
            this.pointYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scaleKXTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rotatePhiTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.finishFunctionButton = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Label();
            this.scaleKYTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.centerRB = new System.Windows.Forms.RadioButton();
            this.clickRB = new System.Windows.Forms.RadioButton();
            this.rotateLineButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.checkSideButton = new System.Windows.Forms.Button();
            this.checkSideTextBox = new System.Windows.Forms.Label();
            this.convexButton = new System.Windows.Forms.Button();
            this.nonConvexButton = new System.Windows.Forms.Button();
            this.convexLabel = new System.Windows.Forms.Label();
            this.nonConvexLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pointButton
            // 
            this.pointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointButton.Location = new System.Drawing.Point(876, 12);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(75, 23);
            this.pointButton.TabIndex = 0;
            this.pointButton.Text = "Point";
            this.pointButton.UseVisualStyleBackColor = true;
            this.pointButton.Click += new System.EventHandler(this.pointButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 850);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lineButton
            // 
            this.lineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineButton.Location = new System.Drawing.Point(876, 41);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(75, 23);
            this.lineButton.TabIndex = 2;
            this.lineButton.Text = "Line";
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // polygonButton
            // 
            this.polygonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.polygonButton.Location = new System.Drawing.Point(876, 70);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(75, 23);
            this.polygonButton.TabIndex = 3;
            this.polygonButton.Text = "Polygon";
            this.polygonButton.UseVisualStyleBackColor = true;
            this.polygonButton.Click += new System.EventHandler(this.polygonButton_Click);
            // 
            // drawPolygonButton
            // 
            this.drawPolygonButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPolygonButton.Location = new System.Drawing.Point(876, 559);
            this.drawPolygonButton.Name = "drawPolygonButton";
            this.drawPolygonButton.Size = new System.Drawing.Size(75, 35);
            this.drawPolygonButton.TabIndex = 4;
            this.drawPolygonButton.Text = "Draw Polygon";
            this.drawPolygonButton.UseVisualStyleBackColor = true;
            this.drawPolygonButton.Visible = false;
            this.drawPolygonButton.Click += new System.EventHandler(this.drawPolygonButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(876, 600);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dxdyButton
            // 
            this.dxdyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dxdyButton.Location = new System.Drawing.Point(12, 571);
            this.dxdyButton.Name = "dxdyButton";
            this.dxdyButton.Size = new System.Drawing.Size(75, 23);
            this.dxdyButton.TabIndex = 6;
            this.dxdyButton.Text = "dx dy";
            this.dxdyButton.UseVisualStyleBackColor = true;
            this.dxdyButton.Click += new System.EventHandler(this.dxdyButton_Click);
            // 
            // scaleButton
            // 
            this.scaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleButton.Location = new System.Drawing.Point(93, 571);
            this.scaleButton.Name = "scaleButton";
            this.scaleButton.Size = new System.Drawing.Size(83, 23);
            this.scaleButton.TabIndex = 7;
            this.scaleButton.Text = "Scale";
            this.scaleButton.UseVisualStyleBackColor = true;
            this.scaleButton.Click += new System.EventHandler(this.scaleButton_Click);
            // 
            // rotateButton
            // 
            this.rotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateButton.Location = new System.Drawing.Point(182, 571);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(76, 23);
            this.rotateButton.TabIndex = 8;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.rotateButton_Click);
            // 
            // dxTextBox
            // 
            this.dxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dxTextBox.Location = new System.Drawing.Point(21, 603);
            this.dxTextBox.Name = "dxTextBox";
            this.dxTextBox.Size = new System.Drawing.Size(24, 20);
            this.dxTextBox.TabIndex = 9;
            this.dxTextBox.Text = "0";
            this.dxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dyTextBox
            // 
            this.dyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dyTextBox.Location = new System.Drawing.Point(51, 603);
            this.dyTextBox.Name = "dyTextBox";
            this.dyTextBox.Size = new System.Drawing.Size(24, 20);
            this.dyTextBox.TabIndex = 10;
            this.dyTextBox.Text = "0";
            this.dyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "dx";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 626);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "dy";
            // 
            // pointXTextBox
            // 
            this.pointXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pointXTextBox.Location = new System.Drawing.Point(264, 591);
            this.pointXTextBox.Name = "pointXTextBox";
            this.pointXTextBox.Size = new System.Drawing.Size(24, 20);
            this.pointXTextBox.TabIndex = 13;
            this.pointXTextBox.Text = "0";
            this.pointXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointYTextBox
            // 
            this.pointYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pointYTextBox.Location = new System.Drawing.Point(294, 591);
            this.pointYTextBox.Name = "pointYTextBox";
            this.pointYTextBox.Size = new System.Drawing.Size(24, 20);
            this.pointYTextBox.TabIndex = 14;
            this.pointYTextBox.Text = "0";
            this.pointYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(268, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "X";
            // 
            // scaleKXTextBox
            // 
            this.scaleKXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleKXTextBox.Location = new System.Drawing.Point(108, 603);
            this.scaleKXTextBox.Name = "scaleKXTextBox";
            this.scaleKXTextBox.Size = new System.Drawing.Size(24, 20);
            this.scaleKXTextBox.TabIndex = 16;
            this.scaleKXTextBox.Text = "1";
            this.scaleKXTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(298, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "kX";
            // 
            // rotatePhiTextBox
            // 
            this.rotatePhiTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotatePhiTextBox.Location = new System.Drawing.Point(208, 603);
            this.rotatePhiTextBox.Name = "rotatePhiTextBox";
            this.rotatePhiTextBox.Size = new System.Drawing.Size(24, 20);
            this.rotatePhiTextBox.TabIndex = 21;
            this.rotatePhiTextBox.Text = "0";
            this.rotatePhiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Phi";
            // 
            // finishFunctionButton
            // 
            this.finishFunctionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishFunctionButton.Location = new System.Drawing.Point(876, 559);
            this.finishFunctionButton.Name = "finishFunctionButton";
            this.finishFunctionButton.Size = new System.Drawing.Size(75, 35);
            this.finishFunctionButton.TabIndex = 25;
            this.finishFunctionButton.Text = "Redraw";
            this.finishFunctionButton.UseVisualStyleBackColor = true;
            this.finishFunctionButton.Visible = false;
            // 
            // hint
            // 
            this.hint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hint.AutoSize = true;
            this.hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hint.Location = new System.Drawing.Point(704, 579);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(147, 31);
            this.hint.TabIndex = 26;
            this.hint.Text = "Just click it";
            this.hint.Visible = false;
            // 
            // scaleKYTextBox
            // 
            this.scaleKYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scaleKYTextBox.Location = new System.Drawing.Point(138, 603);
            this.scaleKYTextBox.Name = "scaleKYTextBox";
            this.scaleKYTextBox.Size = new System.Drawing.Size(24, 20);
            this.scaleKYTextBox.TabIndex = 27;
            this.scaleKYTextBox.Text = "1";
            this.scaleKYTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 626);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "kY";
            // 
            // centerRB
            // 
            this.centerRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.centerRB.AutoSize = true;
            this.centerRB.Location = new System.Drawing.Point(270, 640);
            this.centerRB.Name = "centerRB";
            this.centerRB.Size = new System.Drawing.Size(56, 17);
            this.centerRB.TabIndex = 29;
            this.centerRB.Text = "Center";
            this.centerRB.UseVisualStyleBackColor = true;
            this.centerRB.Click += new System.EventHandler(this.centerRB_Click);
            // 
            // clickRB
            // 
            this.clickRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clickRB.AutoSize = true;
            this.clickRB.Checked = true;
            this.clickRB.Location = new System.Drawing.Point(270, 617);
            this.clickRB.Name = "clickRB";
            this.clickRB.Size = new System.Drawing.Size(48, 17);
            this.clickRB.TabIndex = 30;
            this.clickRB.TabStop = true;
            this.clickRB.Text = "Click";
            this.clickRB.UseVisualStyleBackColor = true;
            this.clickRB.Click += new System.EventHandler(this.clickRB_Click);
            // 
            // rotateLineButton
            // 
            this.rotateLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateLineButton.Location = new System.Drawing.Point(336, 571);
            this.rotateLineButton.Name = "rotateLineButton";
            this.rotateLineButton.Size = new System.Drawing.Size(76, 23);
            this.rotateLineButton.TabIndex = 31;
            this.rotateLineButton.Text = "Rotate Line";
            this.rotateLineButton.UseVisualStyleBackColor = true;
            this.rotateLineButton.Click += new System.EventHandler(this.rotateLineButton_Click);
            // 
            // findButton
            // 
            this.findButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.findButton.Location = new System.Drawing.Point(336, 603);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(76, 54);
            this.findButton.TabIndex = 32;
            this.findButton.Text = "Find Intersection Point";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // checkSideButton
            // 
            this.checkSideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkSideButton.Location = new System.Drawing.Point(430, 571);
            this.checkSideButton.Name = "checkSideButton";
            this.checkSideButton.Size = new System.Drawing.Size(76, 23);
            this.checkSideButton.TabIndex = 33;
            this.checkSideButton.Text = "Check Side";
            this.checkSideButton.UseVisualStyleBackColor = true;
            this.checkSideButton.Click += new System.EventHandler(this.checkSideButton_Click);
            // 
            // checkSideTextBox
            // 
            this.checkSideTextBox.AutoSize = true;
            this.checkSideTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkSideTextBox.Location = new System.Drawing.Point(443, 897);
            this.checkSideTextBox.Name = "checkSideTextBox";
            this.checkSideTextBox.Size = new System.Drawing.Size(42, 20);
            this.checkSideTextBox.TabIndex = 34;
            this.checkSideTextBox.Text = "Click";
            this.checkSideTextBox.Visible = false;
            this.checkSideTextBox.Click += new System.EventHandler(this.checkSideTextBox_Click);
            // 
            // convexButton
            // 
            this.convexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.convexButton.Location = new System.Drawing.Point(512, 571);
            this.convexButton.Name = "convexButton";
            this.convexButton.Size = new System.Drawing.Size(76, 52);
            this.convexButton.TabIndex = 35;
            this.convexButton.Text = "Check Convex Polygon";
            this.convexButton.UseVisualStyleBackColor = true;
            this.convexButton.Click += new System.EventHandler(this.convexButton_Click);
            // 
            // nonConvexButton
            // 
            this.nonConvexButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nonConvexButton.Location = new System.Drawing.Point(594, 571);
            this.nonConvexButton.Name = "nonConvexButton";
            this.nonConvexButton.Size = new System.Drawing.Size(76, 52);
            this.nonConvexButton.TabIndex = 36;
            this.nonConvexButton.Text = "Check Non-Convex Polygon";
            this.nonConvexButton.UseVisualStyleBackColor = true;
            this.nonConvexButton.Click += new System.EventHandler(this.nonConvexButton_Click);
            // 
            // convexLabel
            // 
            this.convexLabel.AutoSize = true;
            this.convexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convexLabel.Location = new System.Drawing.Point(520, 926);
            this.convexLabel.Name = "convexLabel";
            this.convexLabel.Size = new System.Drawing.Size(62, 20);
            this.convexLabel.TabIndex = 37;
            this.convexLabel.Text = "Waiting";
            // 
            // nonConvexLabel
            // 
            this.nonConvexLabel.AutoSize = true;
            this.nonConvexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nonConvexLabel.Location = new System.Drawing.Point(602, 926);
            this.nonConvexLabel.Name = "nonConvexLabel";
            this.nonConvexLabel.Size = new System.Drawing.Size(62, 20);
            this.nonConvexLabel.TabIndex = 38;
            this.nonConvexLabel.Text = "Waiting";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, -6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(803, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nonConvexLabel);
            this.Controls.Add(this.convexLabel);
            this.Controls.Add(this.nonConvexButton);
            this.Controls.Add(this.convexButton);
            this.Controls.Add(this.checkSideTextBox);
            this.Controls.Add(this.checkSideButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.rotateLineButton);
            this.Controls.Add(this.clickRB);
            this.Controls.Add(this.centerRB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.scaleKYTextBox);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rotatePhiTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scaleKXTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pointYTextBox);
            this.Controls.Add(this.pointXTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dyTextBox);
            this.Controls.Add(this.dxTextBox);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.scaleButton);
            this.Controls.Add(this.dxdyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.drawPolygonButton);
            this.Controls.Add(this.polygonButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pointButton);
            this.Controls.Add(this.finishFunctionButton);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button drawPolygonButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button dxdyButton;
        private System.Windows.Forms.Button scaleButton;
        private System.Windows.Forms.Button rotateButton;
        private System.Windows.Forms.TextBox dxTextBox;
        private System.Windows.Forms.TextBox dyTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pointXTextBox;
        private System.Windows.Forms.TextBox pointYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox scaleKXTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rotatePhiTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button finishFunctionButton;
        private System.Windows.Forms.Label hint;
        private System.Windows.Forms.TextBox scaleKYTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton centerRB;
        private System.Windows.Forms.RadioButton clickRB;
        private System.Windows.Forms.Button rotateLineButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button checkSideButton;
        private System.Windows.Forms.Label checkSideTextBox;
        private System.Windows.Forms.Button convexButton;
        private System.Windows.Forms.Button nonConvexButton;
        private System.Windows.Forms.Label convexLabel;
        private System.Windows.Forms.Label nonConvexLabel;
        private System.Windows.Forms.Button button1;
    }
}

