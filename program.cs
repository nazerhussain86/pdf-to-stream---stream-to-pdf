class Program
{
    static void Main()
    {
        string localFilePath = @"D:\Nazer_Hussain\a_Reading_Files\Yazaki Reading\Yazaki Supplier Docs\YAZAKI CORPORATION.pdf";
        // Read PDF to stream
        string ext = Path.GetExtension(localFilePath);
        string FileName = Path.GetFileName(localFilePath).Replace(ext, "");
        byte[] pdfBytes = System.IO.File.ReadAllBytes(localFilePath);
        MemoryStream pdfStream = new MemoryStream(pdfBytes);
        // Write stream to new PDF
        FileStream fs = new FileStream(@"D:\Nazer_Hussain\ConsoleInvoice\outputtxtfiles\downloadfile\" + FileName + ext, FileMode.OpenOrCreate);
        pdfStream.CopyTo(fs);
      
    }
}
