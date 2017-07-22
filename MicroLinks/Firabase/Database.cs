using System;
using System.Collections.Generic;
using System.Text;
using FirebaseNet.Database;
using System.IO;

namespace MicroLinks.Firabase
{
    public class Database
    {
        private const string MicroURL = "http://mlnk.ml/";

        private static readonly Database instance = new Database();

        static Database() { }

        private Database() { }

        public static Database Get
        {
            get
            {
                return instance;
            }
        }

        FirebaseDB MicroLinksDB = new FirebaseDB("https://c-sharpcorner-2d7ae.firebaseio.com").Node("MicroLinks");

        public bool IsAvailable(string keyword)
        {
            var response = MicroLinksDB.Node(keyword).Get();
            if (response.Success && response.JSONContent != null)
                return false;
            else
                return true;
        }

        public string PushLink(string uri)
        {
            var keyword = Path.GetRandomFileName().Substring(0, 5);
            var message = ("{\"" + keyword + "\":{\"Dest\":\"" + uri + "\",\"Hits\":\"0\"}}");
            if (MicroLinksDB.Patch(message).Success)
                return MicroURL + keyword;
            else
                return string.Empty;
        }

        public string GetLinK(string keyword)
        {
            var response = MicroLinksDB.Node(keyword).Node("Dest").Get();
            if (response.Success && response.JSONContent != null)
                return response.JSONContent;
            else
                return string.Empty;
        }
    }
}