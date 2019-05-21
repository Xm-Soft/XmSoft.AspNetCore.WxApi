using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmSoft.AspNetCore.WxApi
{
    public enum FileType
    {
        Jpg = 255216,
        Gif = 7173,
        Bmp = 6677,
        Png = 13780,
        Com = 7790,
        Exe = 7790,
        Dll = 7790,
        Rar = 8297,
        Zip = 8075,
        Xml = 6063,
        Html = 6033,
        Aapx = 239187,
        Cs = 117115,
        Js = 119105,
        Txt = 210187,
        Sql = 255254,
        Bat = 64101,
        Btseed = 10056,
        Rdp = 255254,
        Psd = 5666,
        Pdf = 3780,
        Chm = 7384,
        Log = 70105,
        Rrg = 8269,
        Hlp = 6395,
        Doc = 208207,
        Xls = 208207,
        Docx = 208207,
        Xlsx = 208207,
        Mp3 = 7368,
        Mp4
    }
    public class FileContentType
    {
        public static IDictionary<FileType,string> Types()
        {
            var parameters = new Dictionary<FileType,string>
            {
                { FileType.Jpg,"image/jpeg" },
                { FileType.Gif,"image/gif" },
                { FileType.Doc, "application/msword" },
                { FileType.Bmp,"application/x-bmp" },
                { FileType.Png,"image/png" },
                { FileType.Js,"application/x-javascript" },
                { FileType.Mp3,"audio/mp3" },
                { FileType.Mp4,"video/mpeg4" }
                
                
            };
            return parameters;
        }
        public static string Get(byte[] bytes)
        {
            var type = int.Parse($"{bytes[0].ToString()}{bytes[1].ToString()}");
            var result = Types().FirstOrDefault(o => o.Key == (FileType)Enum.ToObject(typeof(FileType),type));
            return result.Value;
        }
    }
}
