// Full file name
using System.Text;

string fileName = @"C:\Users\Mehrshad\OneDrive\Desktop\DSC_0215.jpg";
FileInfo fi = new FileInfo(fileName);

//create file
using (FileStream fs = fi.Create())
{
    Byte[] txt = new UTF8Encoding(true).GetBytes("New file.");
    fs.Write(txt, 0, txt.Length);
    byte[] author = new UTF8Encoding(true).GetBytes("Mehrhsad Asadi");
    fs.Write(author, 0, author.Length);
}


//file name
string justfileName = fi.Name;
Console.WriteLine("File Name {0}", justfileName);
//file full name
string fullFileName = fi.FullName;
Console.WriteLine("Full Name {0}", fullFileName);
// get file extencion
string extn = fi.Extension; 
Console.WriteLine("Extencion {0}", extn);

if (fi.Exists)
{
    long size = fi.Length;
    Console.WriteLine("size is {0}" , size);
}
