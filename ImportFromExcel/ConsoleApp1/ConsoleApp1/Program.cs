using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using ConsoleApp1.Model;
using OfficeOpenXml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new PgContext())
            {


                //var resp = db.CitiesDbSet.Where(x => x.DenominazioneRegione == "Sardegna").FirstOrDefault();



                //var r = resp.ToList();

                //;

                //var resp = db.CitiesDbSet.Where(x => x.CodiceRegione == 1).ToList();

                var filePath = @"C:/GitHub/Playground/ImportFromExcel/ConsoleApp1/ConsoleApp1/ExcelFile/comuni.xlsx";
                FileInfo file = new FileInfo(filePath);

                using (ExcelPackage package = new ExcelPackage(file))
                {
                    StringBuilder sb = new StringBuilder();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                    int rowCount = worksheet.Dimension.Rows;
                    int ColCount = worksheet.Dimension.Columns;

                    var rawText = string.Empty;

                    //row = 2 to be header skipped
                    for (int row = 2; row <= rowCount; row++)
                    {
                        var city = new Cities();

                        for (int col = 1; col <= ColCount; col++)
                        {

                            if (worksheet.Cells[row, col].Value == null)
                            {
                                continue;
                            }

                            switch (col)
                            {
                                case 1:
                                    city.CodiceRegione = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;
                                case 2:
                                    city.CodiceUnita = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;

                                case 3:
                                    city.CodiceProvincia = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;

                                case 4:
                                    city.ProgressivoComune = Convert.ToInt32(worksheet.Cells[row, col].Value);
                                    break;


                                case 5:
                                    city.CodiceComune = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 6:
                                    city.DenominazioneItalianaStraniera = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 7:
                                    city.DenominazioneItaliana = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 8:
                                    city.DenominazioneAltraLingua = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 9:
                                    city.CodiceRipartizioneGeografica = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;

                                case 10:
                                    city.RipartizioneGeografica = worksheet.Cells[row, col].Value.ToString();
                                    break;


                                case 11:
                                    city.DenominazioneRegione = worksheet.Cells[row, col].Value.ToString();

                                    break;

                                case 12:
                                    city.DenominazioneUnita = worksheet.Cells[row, col].Value.ToString();

                                    break;

                                case 13:
                                    city.FlagComuneCapoluogo = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;

                                case 14:
                                    city.SiglaAutomobilistica = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 15:
                                    city.CodiceComuneFormatoNumerico = Convert.ToInt32(worksheet.Cells[row, col].Value);
                                    break;

                                case 16:
                                    city.CodiceComuneNumericoCon110Province = Convert.ToInt32(worksheet.Cells[row, col].Value);
                                    break;


                                case 17:
                                    city.CodiceComuneNumericoCon107Province = Convert.ToInt32(worksheet.Cells[row, col].Value);

                                    break;

                                case 18:
                                    city.CodiceComuneNumericoCon103Province = Convert.ToInt32(worksheet.Cells[row, col].Value);
                                    break;

                                case 19:

                                    city.CodiceCatastale = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 20:
                                    city.PopolazioneLegale2011 = Convert.ToInt32(worksheet.Cells[row, col].Value);
                                    break;

                                case 21:
                                    city.Nuts1 = worksheet.Cells[row, col].Value.ToString();
                                    break;

                                case 22:
                                    city.Nuts2 = worksheet.Cells[row, col].Value.ToString();
                                    break;


                                case 23:
                                    city.Nuts3 = worksheet.Cells[row, col].Value.ToString();
                                    break;
                            }


                        }

                        db.CitiesDbSet.Add(city);

                    }

                    db.SaveChanges();

                    Console.WriteLine(rawText);
                }
            }


        }




    }


}
