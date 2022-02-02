using System;
using System.Net;
using System.IO;
using PRISMPLAYERLib;
using Newtonsoft.Json;
using System.Configuration;

namespace PrismApp
{
    class Program
    {
        //静的フィールドの変数
        public static MyPrismClass prismPlayerClass = new MyPrismClass();
        static void Main(string[] args)
        {
            //通信機能
            var thisServer = ConfigurationManager.AppSettings["ThisServer"];
            // var thisServer = "localhost";
            var prismLink = $"http://{thisServer}/prism/";

            Console.WriteLine($"PrismServer Start at {prismLink}");
            //Httpサーバー生成
            HttpListener listener = new HttpListener();

            listener.Prefixes.Clear();
            listener.Prefixes.Add(prismLink);

            listener.Start();

            // Webメインループ
            while (true)
            {
                //リクエスト待ち
                HttpListenerContext context = listener.GetContext();
                Console.WriteLine("---------------------------通信が来ました---------------------------");

                //リクエスト取得
                HttpListenerRequest req = context.Request;

                //JSONテキストを取得
                // var reader = new StreamReader(req.InputStream, req.ContentEncoding);
                var reader = new StreamReader(req.InputStream, System.Text.Encoding.UTF8);
                var jsonText = reader.ReadToEnd();
                Console.WriteLine("jsonText↓↓↓↓↓");
                Console.WriteLine(jsonText);

                //クラスに変換
                var prismUser = JsonConvert.DeserializeObject<UserClass>(jsonText);
                prismUser.log();
                //ここで作画したい。
                var frame = prismUser.RFrame();
                prismPlayerClass.Load();
                frame.Kumitate(prismPlayerClass, prismUser.csvtoarr);
                Console.WriteLine("組み立て完了");
                prismPlayerClass.DumpPicture();
                prismPlayerClass.DumpScene();

                // レスポンス取得
                HttpListenerResponse res = context.Response;

                res.StatusCode = 200;
                res.ContentType = "application/json";
                res.AppendHeader("Access-Control-Allow-Origin", "*");

                // 画像ファイルを読み込む
                StreamWriter writer = new StreamWriter(res.OutputStream);
                string inFileName = @"D:\PrismApp\ok.png";
                FileStream inFile = new System.IO.FileStream(inFileName, FileMode.Open, FileAccess.Read);
                byte[] bs = new byte[inFile.Length];
                inFile.Read(bs, 0, (int)inFile.Length);
                inFile.Close();

                //Base64で文字列に変換
                string base64String = System.Convert.ToBase64String(bs);
                writer.Write("{\"imageData\":\"" + base64String + "\"}");
                writer.Flush();

                res.OutputStream.Close();

                // レスポンスエンド
                Console.WriteLine("レスポンスエンド");
                res.Close();
            }
        }
    }


    public class UserClass
    {
        //public string userId { get; set; }
        public string catalogName { get; set; }
        public string messageCsv { get; set; }

        public string[] csvtoarr
        {
            get { return messageCsv.Split(','); }
        }

        public void log()
        {
            Console.WriteLine(catalogName);
            Console.WriteLine(messageCsv);
        }

        //コメントを追加しました。
        public Frame RFrame()
        {
            Frame frame;
            switch (catalogName)
            {
                case "HanaFrame":
                    frame = new HanaFrame();
                    break;
                case "RibonFrame":
                    frame = new RibonFrame();
                    break;
                case "UmeFrema":
                    frame = new UmeFrame();
                    break;
                case "TorukoFrame":
                    frame = new TorukoFrame();
                    break;
                case "5":
                    frame = new HanaFrame();
                    break;
                case "6":
                    frame = new HanaFrame();
                    break;
                case "7":
                    frame = new HanaFrame();
                    break;
                case "8":
                    frame = new HanaFrame();
                    break;
                case "9":
                    frame = new HanaFrame();
                    break;
                default:
                    frame = new HanaFrame();
                    break;
            }
            return frame;
        }
    }
}