using System;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AudioBooks
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(FileUpload.HasFile)
                {
                    string path = Path.GetFileName(FileUpload.FileName);
                    FileUpload.SaveAs(Server.MapPath("~/AudioFiles/" + path));
                    String link = "AudioFiles/" + path;
                    link = "<audio Controls><Source src=" + link + " type=audio/mpeg><video>";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}