using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            String path = @"C:\Mata\PipeAndFilters\PII_Pipes_Filters_Start\src\Program\luke.jpg";
            String pathF =@"C:\Mata\PipeAndFilters\PII_Pipes_Filters_Start\src\Program\lukeFiltrado.jpg" ;
            PipeNull pipeN = new PipeNull();
            FilterNegative fNegativo = new FilterNegative();
            PipeSerial pipe2 = new PipeSerial(fNegativo, pipeN);
            FilterGreyscale fGris = new FilterGreyscale();
            PipeSerial pipe1 = new PipeSerial(fGris, pipe2);
            p.SavePicture(pipe1.Send(p.GetPicture(path)), pathF);
        }
    }
}
