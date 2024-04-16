namespace appFileControl
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
      btnSelectFolder = new Button();
      txtFolder = new TextBox();
      btnProcessFolder = new Button();
      txtProcessFileNumber = new TextBox();
      btnOpenTextFile = new Button();
      txtContent = new TextBox();
      btnSaveTextFile = new Button();
      SuspendLayout();
      // 
      // btnSelectFolder
      // 
      btnSelectFolder.Font = new Font("Segoe UI", 20F);
      btnSelectFolder.Location = new Point(12, 25);
      btnSelectFolder.Name = "btnSelectFolder";
      btnSelectFolder.Size = new Size(253, 71);
      btnSelectFolder.TabIndex = 0;
      btnSelectFolder.Text = "Select Folder";
      btnSelectFolder.UseVisualStyleBackColor = true;
      btnSelectFolder.Click += btnSelectFolder_Click;
      // 
      // txtFolder
      // 
      txtFolder.Font = new Font("Segoe UI", 20F);
      txtFolder.Location = new Point(291, 39);
      txtFolder.Name = "txtFolder";
      txtFolder.ReadOnly = true;
      txtFolder.Size = new Size(428, 43);
      txtFolder.TabIndex = 1;
      // 
      // btnProcessFolder
      // 
      btnProcessFolder.Font = new Font("Segoe UI", 20F);
      btnProcessFolder.Location = new Point(746, 25);
      btnProcessFolder.Name = "btnProcessFolder";
      btnProcessFolder.Size = new Size(253, 71);
      btnProcessFolder.TabIndex = 2;
      btnProcessFolder.Text = "Process Folder";
      btnProcessFolder.UseVisualStyleBackColor = true;
      btnProcessFolder.Click += btnProcessFolder_Click;
      // 
      // txtProcessFileNumber
      // 
      txtProcessFileNumber.Font = new Font("Segoe UI", 20F);
      txtProcessFileNumber.Location = new Point(1025, 39);
      txtProcessFileNumber.Name = "txtProcessFileNumber";
      txtProcessFileNumber.ReadOnly = true;
      txtProcessFileNumber.Size = new Size(428, 43);
      txtProcessFileNumber.TabIndex = 3;
      // 
      // btnOpenTextFile
      // 
      btnOpenTextFile.Font = new Font("Segoe UI", 20F);
      btnOpenTextFile.Location = new Point(12, 136);
      btnOpenTextFile.Name = "btnOpenTextFile";
      btnOpenTextFile.Size = new Size(253, 71);
      btnOpenTextFile.TabIndex = 4;
      btnOpenTextFile.Text = "Open Text File";
      btnOpenTextFile.UseVisualStyleBackColor = true;
      btnOpenTextFile.Click += btnOpenTextFile_Click;
      // 
      // txtContent
      // 
      txtContent.Font = new Font("Segoe UI", 20F);
      txtContent.Location = new Point(12, 231);
      txtContent.Multiline = true;
      txtContent.Name = "txtContent";
      txtContent.ScrollBars = ScrollBars.Both;
      txtContent.Size = new Size(1441, 506);
      txtContent.TabIndex = 5;
      // 
      // btnSaveTextFile
      // 
      btnSaveTextFile.Font = new Font("Segoe UI", 20F);
      btnSaveTextFile.Location = new Point(1200, 136);
      btnSaveTextFile.Name = "btnSaveTextFile";
      btnSaveTextFile.Size = new Size(253, 71);
      btnSaveTextFile.TabIndex = 6;
      btnSaveTextFile.Text = "Save Text File";
      btnSaveTextFile.UseVisualStyleBackColor = true;
      btnSaveTextFile.Click += btnSaveTextFile_Click;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1524, 777);
      Controls.Add(btnSaveTextFile);
      Controls.Add(txtContent);
      Controls.Add(btnOpenTextFile);
      Controls.Add(txtProcessFileNumber);
      Controls.Add(btnProcessFolder);
      Controls.Add(txtFolder);
      Controls.Add(btnSelectFolder);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnSelectFolder;
    private TextBox txtFolder;
    private Button btnProcessFolder;
    private TextBox txtProcessFileNumber;
    private Button btnOpenTextFile;
    private TextBox txtContent;
    private Button btnSaveTextFile;
  }
}
