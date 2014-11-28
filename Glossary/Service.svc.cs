using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Glossary.MyDBTableAdapters;

namespace Glossary
{
    public class Service : IService
    {
        public List<BO.Word> Search(string query)
        {
            WordsTableAdapter Ta = new WordsTableAdapter();
            MyDB.WordsDataTable Dt;

            if (query.Trim().Length > 0)
            {
                Dt = Ta.Search(query);
            }
            else
            {
                Dt = Ta.SelectAllWords();
            }

            List<BO.Word> wList = new List<BO.Word>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                BO.Word w = new BO.Word();
                w.ID = long.Parse(Dt[i]["ID"].ToString());
                w.Description = CutLetters(Dt[i]["Description"].ToString());
                w.Persian = Dt[i]["Persian"].ToString();
                w.English = Dt[i]["English"].ToString();


                //Load Details:
                List<BO.Word_Details> wDList = new List<BO.Word_Details>();
                Words_DetailsTableAdapter TaWd = new Words_DetailsTableAdapter();
                MyDB.Words_DetailsDataTable dtDet = TaWd.SelectByWid(w.ID);
                for (int j = 0; j < dtDet.Rows.Count; j++)
                {
                    BO.Word_Details wd = new BO.Word_Details();
                    wd.Body = dtDet[j]["Body"].ToString();
                    wd.Kind = int.Parse(dtDet[j]["Kind"].ToString());

                    wDList.Add(wd);
                }
                if (wDList.Count > 0)
                    w.Details = wDList;



                //Load Tags:
                List<BO.Tags> wTags = new List<BO.Tags>();
                TagsTableAdapter TgA = new TagsTableAdapter();
                MyDB.TagsDataTable dtTags = TgA.SelectWordTagss(int.Parse(w.ID.ToString()));
                for (int j = 0; j < dtTags.Rows.Count; j++)
                {
                    BO.Tags tg = new BO.Tags();
                    tg.Title = dtTags[j]["tgTitle"].ToString();
                    tg.Id = int.Parse(dtTags[j]["tgid"].ToString());

                    wTags.Add(tg);
                }

                if (wTags.Count > 0)
                    w.Tags = wTags;


                wList.Add(w);

            }

            return wList;
        }
        public static string CutLetters(string inStr)
        {
            string RetStr = "";
            string[] W = inStr.Split(' ');
            if (W.Length > 30)
            {
                for (int i = 0; i < 30; i++)
                {
                    RetStr += " " + W[i];
                }
                RetStr += " ... ";
            }
            else
            {
                RetStr = inStr;
            }

            return RetStr;

        }
        public List<BO.Word> SearchStart(string start)
        {
            WordsTableAdapter Ta = new WordsTableAdapter();
            MyDB.WordsDataTable Dt = Ta.wordsSelectByStart(start);

            List<BO.Word> wList = new List<BO.Word>();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                BO.Word w = new BO.Word();
                w.ID = long.Parse(Dt[i]["ID"].ToString());
                w.Description = CutLetters(Dt[i]["Description"].ToString());
                w.Persian = Dt[i]["Persian"].ToString();
                w.English = Dt[i]["English"].ToString();


                //Load Details:
                List<BO.Word_Details> wDList = new List<BO.Word_Details>();
                Words_DetailsTableAdapter TaWd = new Words_DetailsTableAdapter();
                MyDB.Words_DetailsDataTable dtDet = TaWd.SelectByWid(w.ID);
                for (int j = 0; j < dtDet.Rows.Count; j++)
                {
                    BO.Word_Details wd = new BO.Word_Details();
                    wd.Body = dtDet[j]["Body"].ToString();
                    wd.Kind = int.Parse(dtDet[j]["Kind"].ToString());

                    wDList.Add(wd);
                }

                if (wDList.Count > 0)
                    w.Details = wDList;



                //Load Tags:
                List<BO.Tags> wTags = new List<BO.Tags>();
                TagsTableAdapter TgA = new TagsTableAdapter();
                MyDB.TagsDataTable dtTags = TgA.SelectWordTagss(int.Parse(w.ID.ToString()));
                for (int j = 0; j < dtTags.Rows.Count; j++)
                {
                    BO.Tags tg = new BO.Tags();
                    tg.Title = dtTags[j]["tgTitle"].ToString();
                    tg.Id = int.Parse(dtTags[j]["tgid"].ToString());

                    wTags.Add(tg);
                }

                if (wTags.Count > 0)
                    w.Tags = wTags;

                wList.Add(w);
            }

            return wList;
        }
        public List<BO.Word> excelToDb()
        {
            return Utility.excelToDb();
        }

        public BO.Word selectWordById(string Id)
        {
            WordsTableAdapter Ta = new WordsTableAdapter();
            MyDB.WordsDataTable Dt = Ta.selectWordById(long.Parse(Id));


            BO.Word w = new BO.Word();
            if (Dt.Rows.Count == 1)
            {
                w.ID = long.Parse(Dt[0]["ID"].ToString());
                w.Description = CutLetters(Dt[0]["Description"].ToString());
                w.Persian = Dt[0]["Persian"].ToString();
                w.English = Dt[0]["English"].ToString();


                //Load Details:
                List<BO.Word_Details> wDList = new List<BO.Word_Details>();
                Words_DetailsTableAdapter TaWd = new Words_DetailsTableAdapter();
                MyDB.Words_DetailsDataTable dtDet = TaWd.SelectByWid(w.ID);
                for (int j = 0; j < dtDet.Rows.Count; j++)
                {
                    BO.Word_Details wd = new BO.Word_Details();
                    wd.Body = dtDet[j]["Body"].ToString();
                    wd.Kind = int.Parse(dtDet[j]["Kind"].ToString());

                    wDList.Add(wd);
                }

                if (wDList.Count > 0)
                    w.Details = wDList;



                //Load Tags:
                List<BO.Tags> wTags = new List<BO.Tags>();
                TagsTableAdapter TgA = new TagsTableAdapter();
                MyDB.TagsDataTable dtTags = TgA.SelectWordTagss(int.Parse(w.ID.ToString()));
                for (int j = 0; j < dtTags.Rows.Count; j++)
                {
                    BO.Tags tg = new BO.Tags();
                    tg.Title = dtTags[j]["tgTitle"].ToString();
                    tg.Id = int.Parse(dtTags[j]["tgid"].ToString());

                    wTags.Add(tg);
                }

                if (wTags.Count > 0)
                    w.Tags = wTags;
            }


            return w;
        }

    }
}
