using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace AppSite
{
    public partial class Upload : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3ECI093;Initial Catalog=AppSiteTest;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader rd;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.Attributes.Add("enctype", "multipart/form-data");
        }

        protected void Upload_Click(object sender, EventArgs e)
        {
            if (Allowed_Extension() == true)
            {
                try
                {
                    con.Open();
                    string folderPath = Server.MapPath("~/Apps/" + appName.Text + "/");
                    int APPID;
                    Random r = new Random();
                    do
                    {
                        APPID = r.Next(1, 100);
                        cmd = new SqlCommand("select * from App where ID = " + APPID + ";", con);
                        rd = cmd.ExecuteReader();
                    } while (rd.HasRows);                          //Select a unique ID from 1 to 100 
                    rd.Close();
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                        string iconPath = Server.MapPath("~/Apps/" + appName.Text + "/" + "img/");
                        Directory.CreateDirectory(iconPath);
                        string filename = "";
                        string iconname = "";
                        if (FControl.HasFile)
                        {
                            try
                            {
                                filename = Path.GetFileName(FControl.FileName);
                                iconname = Path.GetFileName(IconControl.FileName);
                                FControl.SaveAs(folderPath + filename);
                                IconControl.SaveAs(iconPath + iconname);
                                FileInfo fi = new FileInfo(Convert.ToString(folderPath + Path.GetFileName(FControl.FileName)));
                                FileInfo ic = new FileInfo(Convert.ToString(folderPath + Path.GetFileName(IconControl.FileName)));
                                long size = fi.Length / 1024;
                                cmd.CommandText = "insert into App values(" + APPID + ",'" + appName.Text + "','" + Description.Text + "','" + getTypeFromExtension(fi.Extension) + "'," + size + ");" + "insert into AppLocation values(" + APPID + ",'" + fi.Name.ToString() + "');" + "insert into AppIcon values(" + APPID + ",'" + ic.Name.ToString() + "');";
                                cmd.ExecuteNonQuery();
                                foreach (ListItem listItem in Category.Items)
                                {
                                    if (listItem.Selected)
                                    {
                                        cmd.CommandText = "insert into AppCategory values(" + APPID + "," + listItem.Value + ");";
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                con.Close();
                                StatusLabel.Text = "Upload Status: " + "File Uploaded";
                            }
                            catch (Exception ex)
                            {
                                StatusLabel.Text = "Upload Status: Upload Failed. Reason: " + ex.Message;
                            }
                        }
                    }
                    else
                    {
                        StatusLabel.Text = "Upload Status: App Already Exists";
                    }
                }
                catch (Exception ex)
                {
                    StatusLabel.Text += "Exception Occured. Reason:" + ex.Message;
                }
            }
            else
            {
                StatusLabel.Text = "Upload Status: Failed. Reason: Category and file type mismatched...";
            }
        }

        string getTypeFromExtension(string str)
        {
            switch (str)
            {
                case ".7z": return "7-zip compressed file";
                case ".arj": return "ARJ compressed file";
                case ".deb": return "Debian software package file";
                case ".pkg": return "Package file";
                case ".rar": return "RAR file";
                case ".rpm": return "Red Hat Package Manager";
                case ".tar.gz": return "Tarball compressed file";
                case ".z": return "Z compressed file";
                case ".zip": return "Zip compressed file";
                case ".dmg": return "macOS X disk image";
                case ".iso": return "ISO disc image";
                case ".toast": return "Toast disc image";
                case ".vcd": return "Virtual CD";
                case ".csv": return "Comma separated value file";
                case ".dat": return "Data file";
                case ".db":
                case ".dbf": return "Database file";
                case ".log": return "Log file";
                case ".mdb": return "Microsoft Access database file";
                case ".sav": return "Save file";
                case ".sql": return "SQL database file";
                case ".tar": return "Linux / Unix tarball file archive";
                case ".xml": return "XML file";
                case ".apk": return "Android package file";
                case ".bat": return "Batch file";
                case ".bin": return "Binary file";
                case ".cgi": 
                case ".pl": return "Perl script file";
                case ".com": return "MS-DOS command file";
                case ".exe": return "Executable file";
                case ".gadget": return "Windows gadget";
                case ".jar": return "Java Archive file";
                case ".py": return "Python file";
                case ".wsv": return "Windows Script File";
                case ".fnt": return "Windows font file";
                case ".fon": return "Generic font file";
                case ".otf": return "Open type font file";
                case ".ttf": return "TrueType font file";
                case ".ai": return "Adobe Illustrator file";
                case ".bmp": return "Bitmap image";
                case ".gif": return "GIF image";
                case ".ico": return "Icon file";
                case ".jpeg":
                case ".jpg": return "JPEG image";
                case ".png": return "PNG image";
                case ".ps": return "PostScript file";
                case ".psd": return "PSD image";
                case ".svg": return "Scalable Vector Graphics file";
                case ".tif": 
                case ".tiff": return "TIFF image";
                case ".asp":
                case ".aspx": return "Active Server Page file";
                case ".cer": return "Internet security certificate";
                case ".cfm": return "ColdFusion Markup file";
                case ".css": return "Cascading Style Sheet file";
                case ".htm": 
                case ".html": return "HTML file";
                case ".js": return "JavaScript file";
                case ".jsp": return "Java Server Page file";
                case ".part": return "Partially downloaded file";
                case ".php": return "PHP file";
                case ".rss": return "RSS file";
                case ".xhtml": return "XHTML file";
                case ".key": return "Keynote presentation";
                case ".odp": return "OpenOffice Impress presentation file";
                case ".pps": return "PowerPoint slide show";
                case ".ppt": return "PowerPoint presentation";
                case ".pptx": return "PowerPoint Open XML presentation";
                case ".c": return "C source code file";
                case ".class": return "Java class file";
                case ".cpp": return "C++ source code file";
                case ".cs": return "Visual C# source code file";
                case ".h": return "C, C++, and Objective-C header file";
                case ".java": return "Java Source code file";
                case ".sh": return "Bash shell script";
                case ".swift": return "Swift source code file";
                case ".vb": return "Visual Basic file";
                case ".ods": return "OpenOffice Calc spreadsheet file";
                case ".xlr": return "Microsoft Works spreadsheet file";
                case ".xls": return "Microsoft Excel file";
                case ".xlsx": return "Microsoft Excel Open XML spreadsheet file";
                case ".bak": return "Backup file";
                case ".cab": return "Windows Cabinet file";
                case ".cfg": return "Configuration file";
                case ".clp": return "Windows Control panel file";
                case ".cur": return "Windows cursor file";
                case ".dll": return "DLL file";
                case ".dmp": return "DUMP file";
                case ".drv": return "Device driver file";
                case ".icns": return "macOS X icon resource file";
                case ".ini": return "Initialization file";
                case ".ink": return "Windows shortcut file";
                case ".msi": return "Windows installer package";
                case ".sys": return "Windows system file";
                case ".tmp": return "Temporary file";
                case ".3g2": return "3GPP2 multimedia file";
                case ".3gp": return "3GPP multimedia file";
                case ".avi": return "AVI file";
                case ".flv": return "Adobe Flash file";
                case ".h264": return "H.264 video file";
                case ".m4v": return "Apple MP4 video file";
                case ".mkv": return "Matroska Multimedia Container";
                case ".mov": return "Apple QuickTime movie file";
                case ".mp4": return "MPEG4 video file";
                case ".mpg":
                case ".mpeg": return "MPEG video file";
                case ".rm": return "RealMedia file";
                case ".swf": return "Shockwave flash file";
                case ".vob": return "DVD Video Object";
                case ".wmv": return "Windows Media Video file";
                case ".docx":
                case ".doc": return "Microsoft Word file";
                case ".odt": return "OpenOffice Writer document file";
                case ".pdf": return "PDF file";
                case ".rtf": return "Rich Text Format";
                case ".tex": return "A LaTeX document file";
                case ".txt": return "Plain text file";
                case ".wks":
                case ".wps": return "Microsoft Works file";
                case ".wpd": return "WordPerfect document";
                case ".ipa": return "iOS App Store Package";
                case ".mp3": return "MPEG4 audio file";
                case ".aac": return "audio File";
                default: return str;
            }
        }       

        protected bool Allowed_Extension()
        {
            FileInfo fin = new FileInfo(Path.GetFileName(FControl.FileName));
            foreach (ListItem li in Category.Items)
            {
                if (li.Selected)
                {
                    string str = li.Text;
                    switch (str)
                    {
                        case "Windows":
                            {
                                if (fin.Extension == ".exe" || fin.Extension == ".msi")
                                    return true;
                                else
                                    continue;
                            }
                        case "Android":
                            {
                                if (fin.Extension == ".apk" )
                                    return true;
                                else
                                    continue;
                            }
                        case "Iphone":
                            {
                                if (fin.Extension == ".ipa")
                                    return true;
                                else
                                    continue;
                            }
                        case "Linux":
                            {
                                if (fin.Extension == ".deb")
                                    return true;
                                else
                                    continue;
                            }
                        case "Notes":
                            {
                                if (fin.Extension == ".doc" || fin.Extension == ".docx" || fin.Extension == ".pdf" || fin.Extension == ".txt")
                                    return true;
                                else
                                    continue;
                            }
                        case "Games": return true;
                        case "Songs":
                            {
                                if (fin.Extension == ".mp3" || fin.Extension == ".aac")
                                    return true;
                                else
                                    continue;
                            }
                        case "Books":
                            {
                                if (fin.Extension == ".doc" || fin.Extension == ".docx" || fin.Extension == ".pdf" || fin.Extension == ".txt")
                                    return true;
                                else
                                    continue;
                            }
                        default: continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
    }
}