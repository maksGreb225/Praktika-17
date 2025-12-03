using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

[Flags]
enum FileAccess {None, Read, Write, Execute}
    internal class Program
    {
        static void Main(string[] args)
        {
        var f = new File { Permission = FileAccess.Read | FileAccess.Write };
        Console.WriteLine(f.CanRead());
        Console.WriteLine(f.CanWrite());
        }
    }

struct File
{
    public FileAccess Permission;

    public bool CanRead()
    {
        return Permission.HasFlag(FileAccess.Read);
    }

    public bool CanWrite()
    {
        return Permission.HasFlag(FileAccess.Write);
    }
}

