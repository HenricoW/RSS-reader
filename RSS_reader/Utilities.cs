using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Data;
using RSS_reader;

namespace RSS_reader
{
    class NewsItem
    {
        private string title, link, description, pubDate;

        public string Title { get => title; set => title = value; }
        public string Link { get => link; set => link = value; }
        public string Description { get => description; set => description = value; }
        public string PubDate { get => pubDate; set => pubDate = value; }
    }

    class ChannelItem
    {
        private string title, url;
        private DateTime lastUpdated;
        private int folderID;

        public string Title { get => title; set => title = value; }
        public string Url { get => url; set => url = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
        public int FolderID { get => folderID; set => folderID = value; }
    }

    class Controllers
    {
        public static System.Collections.ArrayList RefreshRSS(string rssUrl)
        {
            WebRequest req;
            WebResponse resp;
            Stream stream;
            XmlDocument xml = new XmlDocument();

            req = WebRequest.Create(rssUrl);

            // TODO: add try catch functionality to web request
            
            resp = req.GetResponse();
            stream = resp.GetResponseStream();
            xml.Load(stream);

            XmlNodeList itemNodes = xml.SelectNodes("rss/channel/item");
            XmlNodeList titleNodes = xml.SelectNodes("rss/channel/item/title");
            XmlNodeList linkNodes = xml.SelectNodes("rss/channel/item/link");
            XmlNodeList descriptionNodes = xml.SelectNodes("rss/channel/item/description");
            XmlNodeList pubDateNodes = xml.SelectNodes("rss/channel/item/pubDate");

            System.Collections.ArrayList itemsList = new System.Collections.ArrayList();

            for (int i = 0; i < itemNodes.Count; ++i)
            {
                NewsItem tempNI = new NewsItem();

                tempNI.Title = titleNodes == null ? "" : titleNodes.Item(i).InnerText;
                // sanitize data [varchar(50)], eliminate single quotes for SQL commands
                tempNI.Title = tempNI.Title.Length >= 1000 ? tempNI.Title.Substring(0, 999) : tempNI.Title;
                tempNI.Title.Replace("'", "-");

                tempNI.Link = linkNodes == null ? "" : linkNodes.Item(i).InnerText;
                tempNI.Description = descriptionNodes == null ? "" : descriptionNodes.Item(i).InnerText.Split('<')[0];
                tempNI.PubDate = pubDateNodes == null ? "" : pubDateNodes.Item(i).InnerText.Substring(5, 11);

                itemsList.Add(tempNI);
            }

            return itemsList;
        }
    }
}
