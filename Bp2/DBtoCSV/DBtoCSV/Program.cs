using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            using(BioskopEntities db = new BioskopEntities())
            {
                var List = db.Tabela1.Where(r => r.id > 0).ToList();
                string csv = String.Join(",\n", List.Select(x => x.ToString()).ToArray());
                csv = csv.Replace(" ", "");


                System.IO.File.WriteAllText(@"C:\Users\Aleksa\source\repos\Bp2\Bp2\data.csv", csv);
            }
        }
    }
}
/*
 * USE [Bioskop]
GO

INSERT INTO [dbo].[Tabela1]
           ([id]
           ,[nazivProj]
           ,[datumVremeProj]
           ,[sala]
           ,[trajanje])
     VALUES
           (12345678
           ,'Dambo 3d'
           ,'2018-06-23 07:30:20'
           ,'sala4'
           ,123)
GO



 * */
