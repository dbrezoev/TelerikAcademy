using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
static class PathStorage
{
    private static string separator = new string('-', 30);   
    
   //save paths to a file
   public static void SavePath(Path path)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("paths.txt", true))
            {
                foreach (Point3D point in path.Sequence)
                {
                    writer.WriteLine(point);
                }
                writer.WriteLine(separator);
            }
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message);           
        }
        Console.WriteLine("Saved successfully.");
    }

    //load paths from a file
    public static List<Path> LoadPaths(string file)
    {
        string pattern = @"[0-9]{1,}([\,]*|[\.]*)[0-9]*"; // for example (21,45) (25.56) (4)
        List<Path> result = new List<Path>();
        //parsing algorithm
        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                Path path = new Path();
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line == separator)
                    {
                        result.Add(path);
                        path = new Path();
                        line = reader.ReadLine();
                        continue;
                    }
                    string substring = line.Substring(line.IndexOf('X'));
                    double[] arr = new double[3];
                    MatchCollection collection = Regex.Matches(substring, pattern);
                    double x = double.Parse(collection[0].ToString());
                    double y = double.Parse(collection[1].ToString());
                    double z = double.Parse(collection[2].ToString());

                    Point3D p = new Point3D(x, y, z);
                    path.AddPoint(p);                    
                    line = reader.ReadLine();
                }
            }
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);            
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch(IOException)
        {
            Console.WriteLine("Bad things happened.Try again.");
        }               
        return result;
    }
}