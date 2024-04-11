namespace appFileControl
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      //Open a Foler browser dialog to select the folder
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Select the folder";
      folderBrowserDialog.ShowNewFolderButton = false;
      folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
      //if the user select a folder, set the path to the textbox
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
      {
        return;
      }
      txtFolder.Text = folderBrowserDialog.SelectedPath;

    }

    private void btnProcessFolder_Click(object sender, EventArgs e)
    {
      string[] filesInFolder = Directory.GetFiles(txtFolder.Text);
      //show in txtProcessFileNumber the number of items in the filesInFolder Array
      txtProcessFileNumber.Text = filesInFolder.Length + " file(s) Processed";
      foreach (string file in filesInFolder)
      {
        //Get the file name
        string fileName = Path.GetFileName(file);
        //Get the file extension
        string fileExtension = Path.GetExtension(file);
        //sort the file by extension using a switch
        switch (fileExtension)
        {
          case ".txt":
          case ".xlsx":
          case ".docx":
          case ".pptx":
            //Move the file to the folder to a docs
            if (!Directory.Exists(txtFolder.Text + "\\Docs"))
            {
              Directory.CreateDirectory(txtFolder.Text + "\\Docs");
            }
            File.Move(file, txtFolder.Text + "\\Docs\\" + fileName);
            break;
          case ".jpg":
          case ".jpeg":
          case ".png":
            //Move the file to the  folder if the folder exist else create the folder
            if (!Directory.Exists(txtFolder.Text + "\\Pics"))
            {
              Directory.CreateDirectory(txtFolder.Text + "\\Pics");
            }
            File.Move(file, txtFolder.Text + "\\Pics\\" + fileName);
            break;
          
          default:
            //Move the file to the other folder
            if (!Directory.Exists(txtFolder.Text + "\\other"))
            {
              Directory.CreateDirectory(txtFolder.Text + "\\other");
            }
            File.Move(file, txtFolder.Text + "\\other\\" + fileName);
            break;
        }
      }
    }
  }
}
