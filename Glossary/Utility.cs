
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Glossary
{
    public class Utility
    {
        public static List<BO.Word> excelToDb()
        {
            FileStream stream = File.Open(HttpContext.Current.Server.MapPath("1.xlsx"), FileMode.Open, FileAccess.Read);

           //// IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
           // //excelReader.IsFirstRowAsColumnNames = true;
           // DataSet result = excelReader.AsDataSet();

            List<BO.Word> Lst = new List<BO.Word>();

           // MyDBTableAdapters.WordsTableAdapter Ta = new MyDBTableAdapters.WordsTableAdapter();

           // //Delete old wrods:
           // Ta.DeleteAllWords();

           // //Delete all old tags:
           // Ta.tagsDeleteAll();

           // //Delete all words tags
           // Ta.wordsTagsDeleteAll();

           // //Delete all words tags
           // Ta.wordsDetailsDeleteAll();


           // //Insert Tags:
           // for (int i = 0; i < result.Tables[1].Rows.Count; i++)
           // {
           //     if (result.Tables[1].Rows[i][1].ToString().Trim().Length > 0)
           //     {
           //         Ta.tagsInsert(int.Parse(result.Tables[1].Rows[i][0].ToString().Trim()),
           //             result.Tables[1].Rows[i][1].ToString().Trim(), int.Parse(result.Tables[1].Rows[i][2].ToString().Trim()));
           //     }
           // }




           // for (int i = 0; i < result.Tables[0].Rows.Count; i++)
           // {
           //     int nId = 0;
           //     BO.Word w = new BO.Word();

           //     w.English = result.Tables[0].Rows[i][1].ToString();
           //     w.Persian = result.Tables[0].Rows[i][2].ToString();
           //     w.Description = result.Tables[0].Rows[i][3].ToString();

           //     if (w.English.Trim().Length > 0)
           //     {
           //         //Insert Word:
           //         nId = int.Parse(Ta.Insert_Word(w.English, w.Persian, w.Description).ToString());

           //         //Insert tags for each word:
           //         if (result.Tables[0].Rows[i][4].ToString().Trim().Length > 0)
           //         {
           //             string[] Tg = result.Tables[0].Rows[i][4].ToString().Split('#');
           //             foreach (string tgItem in Tg)
           //             {
           //                 if (tgItem.Trim().Length > 0)
           //                 {
           //                     try
           //                     {
           //                         Ta.wordsTagsInsert(nId, int.Parse(tgItem));
           //                     }
           //                     catch
           //                     { }
           //                 }
           //             }
           //         }




           //         //Insert Ftr for each word:
           //         if (result.Tables[0].Rows[i][5].ToString().Trim().Length > 0)
           //         {
           //             string[] Tg = result.Tables[0].Rows[i][5].ToString().Split('#');
           //             foreach (string ftrItem in Tg)
           //             {
           //                 if (ftrItem.Trim().Length > 0)
           //                 {
           //                     for (int j = 0; j < result.Tables[2].Rows.Count; j++)
           //                     {
           //                         if (result.Tables[2].Rows[j][0].ToString() == ftrItem)
           //                         {
           //                             Ta.wordsDetailsInsert(result.Tables[2].Rows[j][1].ToString(), nId, 1);
           //                         }
           //                     }
           //                 }
           //             }
           //         }



           //         //Insert ref for each word:
           //         if (result.Tables[0].Rows[i][6].ToString().Trim().Length > 0)
           //         {
           //             string[] Tg = result.Tables[0].Rows[i][6].ToString().Split('#');
           //             foreach (string refItem in Tg)
           //             {
           //                 if (refItem.Trim().Length > 0)
           //                 {
           //                     for (int j = 0; j < result.Tables[3].Rows.Count; j++)
           //                     {
           //                         if (result.Tables[3].Rows[j][0].ToString() == refItem)
           //                         {
           //                             Ta.wordsDetailsInsert(result.Tables[3].Rows[j][1].ToString(), nId, 2);
           //                         }
           //                     }
           //                 }
           //             }
           //         }

           //         Lst.Add(w);
           //     }
           // }

           // excelReader.Close();
            stream.Close();
            return Lst;
        }
    }
}