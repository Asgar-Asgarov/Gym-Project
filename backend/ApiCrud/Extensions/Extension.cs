namespace ApiCrud.Extensions;

public static class Extension
{
    public static bool isImage(this IFormFile file)
    {
        return file.ContentType.Contains("image");
    }
    
    public static bool CheckImageSize(this IFormFile file,int size)
    {
        return file.Length / 1024>size;
    }

    public static string SaveImage(this IFormFile file,IWebHostEnvironment env,string root,string fileName)
    {
        fileName = Guid.NewGuid().ToString() + file.FileName;
        string fullPath = Path.Combine(env.WebRootPath,root,fileName);
        using (FileStream stream =new FileStream(fullPath,FileMode.Create))
        {
            file.CopyTo(stream);
        }
        return fileName;
    }

}